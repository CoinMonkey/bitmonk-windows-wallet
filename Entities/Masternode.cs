using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMonk.Entities
{
    class Masternode
    {
        string status;
        string address;
        string protocol;
        string time;

        public Masternode(string setStatus, string setAddress, string setProtocol, string setTime)
        {
            status = setStatus;
            address = setAddress;
            protocol = setProtocol;
            time = setTime;
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Protocol
        {
            get { return protocol; }
            set { protocol = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
