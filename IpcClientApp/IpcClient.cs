using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;

namespace IpcClientApp
{
    public partial class IpcClient
    {
        public NamedPipeClientStream pipe;
        public StreamReader reader;
        public StreamWriter writer;

        private readonly int pollingMillisec = 10;

        private readonly Action<string> messageReceiveCallBack;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IpcClient(Action<string> callBack)
        {
            this.messageReceiveCallBack = callBack;
        }

        /// <summary>
        /// 名前付きパイプを接続する
        /// </summary>
        public async Task<bool> Connect(string ipAddress, string pipeName)
        {
            pipe = new NamedPipeClientStream(ipAddress, pipeName, PipeDirection.InOut, PipeOptions.Asynchronous);
            await pipe.ConnectAsync();

            reader = new StreamReader(pipe);
            writer = new StreamWriter(pipe)
            {
                AutoFlush = true
            };

            return true;
        }

        /// <summary>
        /// 名前付きパイプを切断する
        /// </summary>
        /// <returns></returns>
        public bool Disconnect()
        {
            try
            {
                if (writer != null)
                {
                    writer.Dispose();
                }

                if (reader != null)
                {
                    reader.Dispose();
                }

                if (pipe != null)
                {
                    pipe.Dispose();
                }

                return true;
            }
            catch (IOException e)
            {
                return false;
            }
        }

        /// <summary>
        /// メッセージ受信を待機する
        /// </summary>
        public async Task Listen()
        {
            while (true)
            {
                Thread.Sleep(pollingMillisec);

                if (pipe == null)
                {
                    continue;
                }

                if (reader == null)
                {
                    continue;
                }

                if (writer == null)
                {
                    continue;
                }

                string message = await reader.ReadLineAsync();

                messageReceiveCallBack(message);
                if (message == null)
                {
                    // 切断されるとNullが返却される
                    Disconnect();
                    break;
                }
            }
        }

        /// <summary>
        /// リソースを破棄する
        /// </summary>
        public void Dispose()
        {

        }
    }
}
