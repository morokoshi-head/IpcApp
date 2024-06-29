using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace IpcClientApp
{
    public partial class IpcClient
    {
        public NamedPipeClientStream pipe;
        public StreamReader reader;
        public StreamWriter writer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IpcClient()
        {

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
                    writer.Close();
                    writer.Dispose();
                }

                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }

                if (pipe != null)
                {
                    pipe.Close();
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
        /// リソースを破棄する
        /// </summary>
        public void Dispose()
        {

        }
    }
}
