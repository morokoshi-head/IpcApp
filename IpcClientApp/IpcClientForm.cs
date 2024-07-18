﻿using System;
using System.Windows.Forms;

namespace IpcClientApp
{
    public partial class IpcClientForm : Form
    {
        public IpcClient client;
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

            string message = SendMessageTextBox.Text;

            SendMessage(message);
            SendMessageTextBox.ResetText();
        }

        /// <summary>
        /// メッセージを送信する
        /// </summary>
        private async void SendMessage(string message)
        {
            await client.writer.WriteLineAsync(message);
        }

        /// <summary>
        /// 接続ボタンのクリックイベント
        /// </summary>
        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            DispLog($"サーバに接続します。");

            string ipAddress = IpAddressTextBox.Text;
            string pipe = PipeTextBox.Text;

            client = new IpcClient(message =>
            {
                // メッセージ受信のコールバック定義
                if (message == null)
                {
                    DispLog($"クライアントが切断されました。");
                }
                else
                {
                    DispMessage(ReceiveMessageTextBox, message);
                }
            });

            bool isSuccess = await client.Connect(ipAddress, pipe);

            if (isSuccess != false)
            {
                DispLog($"サーバーに接続しました。");
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
                DispLog($"サーバーとの接続を切断しました。");
            }
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
