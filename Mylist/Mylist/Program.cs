using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mylist
{
    class Program
    {
        static void Main(string[] args)
        {
            FastList fl=new FastList();

            fl.Dizi[0] = 123;
            fl.Dizi[1] = 18;
            fl.Dizi[2] = 234;
            fl.Dizi[3] = 12;
            fl.Dizi[4] = 23;

            
            foreach (var item in fl)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
