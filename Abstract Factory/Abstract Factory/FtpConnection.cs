using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class FtpConnection:IConnection
    {
        public void Connect()
        {
            Console.WriteLine("FtpConnection Bağlandı");
        }

        public void Disconnect()
        {
            Console.WriteLine("FtpConnection Bağlandı");
        }

        public bool State
        {
            get {
                if (true)
                {
                    return true;
                }
            }
        }
    }
}
