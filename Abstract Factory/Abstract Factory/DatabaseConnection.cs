using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class DatabaseConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("DatabaseConnection Bağlandı");
        }

        public void Disconnect()
        {
            Console.WriteLine("DatabaseConnection Kapandı");
        }

        public bool State
        {
            get
            {
                if (true)
                { return true; }
            }
        }
    }
}
