using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Statics.Sehir.baskentPlaka=06;

            Statics.Sehir.Listele(Statics.Sehir.sehirler);

            Console.WriteLine("\n");
             
            Console.WriteLine(Statics.Sehir.Baskent(Statics.Sehir.baskentPlaka));
            

            Console.ReadLine();

        }
    }
}
