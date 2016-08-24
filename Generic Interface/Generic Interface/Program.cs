using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Generic_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunYonetim dukkan=new UrunYonetim();
            IEnumerator<Urun> e = dukkan.GetEnumerator();

            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.Id);
            }
            Console.ReadKey();
        }
    }
}
