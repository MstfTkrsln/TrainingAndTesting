using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_Readline
{
    class Program
    {
        private delegate void delege();
        static void Main(string[] args)
        {

            delege cr = () => Console.ReadLine();

            
            cr();
        }
    }
}
