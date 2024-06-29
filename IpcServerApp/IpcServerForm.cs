using System;
using System.Threading.Tasks;
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
        public void DispMessage(string message)
        {
            MessageTextBox.Text += (message + "\r\n");
        }

        /// <summary>
        /// 接続ボタンのクリックイベント
        /// </summary>
        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            DispLog($"クライアントの接続を待機します。");

            server = new IpcServer(message =>
            {
                if (message == null)
                {
                    DispLog($"クライアントが切断されました。");
                }
                else
                {
                    DispMessage(message);
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
