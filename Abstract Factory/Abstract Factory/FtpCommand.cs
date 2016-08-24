using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class FtpCommand:ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine(query + " : FtpCommand Çalıştırıldı.");
        }
    }
}
