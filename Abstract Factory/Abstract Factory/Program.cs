using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Factory factory1 = new Factory();

            factory1.Start();

            Console.ReadLine();

        }
    }
}
