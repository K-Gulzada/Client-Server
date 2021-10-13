using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServer
{
    public class ReplyStatus
    {
        public string Resource { get; set; }
        public string Status { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return string.Format("{0:HH:mm} - {1}: {2}", TimeStamp, Resource, Status);
        }
    }
}
