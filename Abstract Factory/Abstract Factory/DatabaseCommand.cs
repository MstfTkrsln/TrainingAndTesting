using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class DatabaseCommand:ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine(query+" : DatabaseCommand Çalıştırıldı.");
        }
    }
}
