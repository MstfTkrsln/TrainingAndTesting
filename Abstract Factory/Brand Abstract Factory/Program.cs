using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brand_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groundcover>().ClientMain();

            Console.ReadLine();
        }
    }
}
