using IpcData;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Windows.Forms;

namespace IpcClientApp
{
    public partial class IpcClientForm : Form
    {
        public readonly string appName = "IpcClientApp";

        public IpcClient client;
        public string ipAddress;
        public string pipeName;
        public IpcClientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログを出力する
        /// </summary>
        public void DispLog(string log)
        {
            LogTextBox.Text += (DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss") + " " + log + "\r\n");
        }

        /// <summary>
        /// メッセージを表示する
        /// </summary>
        public void DispMessage(TextBox textBox, string message)
        {
            textBox.Text += (message + "\r\n");
        }

        /// <summary>
        /// 送信ボタンのクリックイベント
        /// </summary>
        private void SendButton_Click(object sender, EventArgs e)
        {
            if ((client == null) || (client.pipe.IsConnected == false))
            {
                return;
            }

            if (client.reader == null)
            {
                return;
            }

            if (client.writer == null)
            {
                return;
            }

            IpcData.IpcData ipcData = new IpcData.IpcData(IpcDataId.message, SendMessageTextBox.Text);

            SendData(ipcData);
            SendMessageTextBox.ResetText();
        }

        /// <summary>
        /// データを送信する
        /// </summary>
        private async void SendData(IpcData.IpcData ipcData)
        {
            await client.writer.WriteLineAsync(JsonSerializer.Serialize(ipcData));
            await client.writer.FlushAsync();
        }

        /// <summary>
        /// 接続ボタンのクリックイベント
        /// </summary>
        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (pipeNameTextBox.Text == null)
            {
                return;
            }

            if (pipeNameTextBox.Text == this.pipeName)
            {
                // 同じ名前付きパイプで複数の通信スレッドは作成しない
                return;
            }

            DispLog($"接続待機中");

            client = new IpcClient(json =>
            {
                // メッセージ受信のコールバック定義
                if (json == null)
                {
                    // 通信が切断されたとき
                    this.Text = appName;
                    this.pipeName = null;
                }
                else
                {
                    // メッセージを受信したとき
                    HandleIpcData(JsonSerializer.Deserialize<IpcData.IpcData>(json));
                }
            });

            this.ipAddress = IpAddressTextBox.Text;
            this.pipeName = pipeNameTextBox.Text;
            bool isSuccess = await client.Connect(ipAddress, pipeName);

            if (isSuccess != false)
            {
                DispLog($"接続完了");

                // 通信先に自身のIPアドレスを渡す
                IPAddress ipAddress = GetOwnIpAddress();
                IpcData.IpcData ipcData = new IpcData.IpcData(IpcDataId.ipAddress, ipAddress.ToString());
                SendData(ipcData);
            }

            await client.Listen();
        }

        /// <summary>
        /// 切断ボタンのクリックイベント
        /// </summary>
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            bool isSuccess = client.Disconnect();
            if (isSuccess != false)
            {
                DispLog($"切断");
            }
        }

        /// <summary>
        /// 受信データを処理する
        /// </summary>
        private void HandleIpcData(IpcData.IpcData ipcData)
        {
            switch (ipcData.id)
            {
                case IpcData.IpcDataId.ipAddress:
                    this.Text = appName + "（" + "通信中：" + ipcData.data + "）";
                    break;

                case IpcData.IpcDataId.message:
                    DispMessage(ReceiveMessageTextBox, ipcData.data);
                    break;

                default:
                    // Donothing
                    break;
            }
        }

        /// <summary>
        /// 自身のIPアドレスを取得する
        /// </summary>
        private IPAddress GetOwnIpAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ipAddress in host.AddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipAddress;
                }
            }

            return null;
        }

        /// <summary>
        /// アプリケーションの終了イベント
        /// </summary>
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            client.Dispose();

            // アプリケーションの終了イベントハンドラを削除
            System.Windows.Forms.Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }
    }
}
