using System;
using System.Windows.Forms;

namespace IpcServerApp
{
    public partial class IpcServerForm : Form
    {
        public readonly string appName = "IpcServerApp";
        public IpcServer server;
        public string pipeName;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IpcServerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログを表示する
        /// </summary>
        public void DispLog(string log)
        {
            LogTextBox.Text += (DateTime.Now.ToString("yyyy/mm/dd/ HH:mm:ss") + " " + log + "\r\n");
        }

        /// <summary>
        /// メッセージを表示する
        /// </summary>
        public void DispMessage(TextBox textBox, string message)
        {
            textBox.Text += (message + "\r\n");
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

            DispLog($"クライアントの接続を待機します。");

            server = new IpcServer(message =>
            {
                // メッセージ受信のコールバック定義
                if (message == null)
                {
                    // 通信が切断されたとき
                    this.Text = appName;
                    this.pipeName = null;
                }
                else
                {
                    // メッセージを受信したとき
                    DispMessage(ReceiveMessageTextBox, message);
                }
            });

            this.pipeName = pipeNameTextBox.Text;
            bool isSuccesss = await server.Connect(this.pipeName);

            if (isSuccesss != false)
            {
                this.Text = appName + "（通信中）";
            }

            await server.Listen();
        }

        /// <summary>
        /// 切断ボタンのクリックイベント
        /// </summary>
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            bool isSuccess = server.Disconnect();
            if (isSuccess != false)
            {
                DispLog($"通信を切断しました。");
            }
        }

        /// <summary>
        /// 送信ボタンのクリックイベント
        /// </summary>
        private void SendButton_Click(object sender, EventArgs e)
        {
            if ((server == null) || (server.pipe.IsConnected == false))
            {
                return;
            }

            if (server.reader == null)
            {
                return;
            }

            if (server.writer == null)
            {
                return;
            }

            string message = SendMessageTextBox.Text;

            SendMessage(message);
            SendMessageTextBox.ResetText();
        }

        /// <summary>
        /// メッセージを送信する
        /// </summary>
        private async void SendMessage(string message)
        {
            await server.writer.WriteLineAsync(message);
            await server.writer.FlushAsync();
        }

        /// <summary>
        /// アプリケーションの終了イベント
        /// </summary>
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            server.Dispose();

            // アプリケーションの終了イベントハンドラを削除
            System.Windows.Forms.Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }
    }
}
