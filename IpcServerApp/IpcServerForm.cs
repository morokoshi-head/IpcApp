using System;
using System.Windows.Forms;

namespace IpcServerApp
{
    public partial class IpcServerForm : Form
    {
        public IpcServer server;

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
            DispLog($"クライアントの接続を待機します。");

            server = new IpcServer(message =>
            {
                // メッセージ受信のコールバック定義
                if (message == null)
                {
                    // Do nothing
                }
                else
                {
                    DispMessage(ReceiveMessageTextBox, message);
                }
            });


            bool isSuccesss = await server.Connect(pipeNameTextBox.Text);

            if (isSuccesss != false)
            {
                DispLog($"クライアントが接続されました。");
            }

            await server.Listen();
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
