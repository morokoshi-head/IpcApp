using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpcData
{
    public enum IpcDataId
    {
        ipAddress = 0,
        message = 1
    }

    public class IpcData
    {
        // Jsonシリアライズにアクセッサが必要
        public IpcDataId id { get; set; }

        public string data { get; set; }

        public IpcData(IpcDataId id, string data)
        {
            this.id = id;
            this.data = data;
        }
    }
}
