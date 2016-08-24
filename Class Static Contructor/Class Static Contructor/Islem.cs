using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Static_Contructor
{
    class Islem
    {
        private static int sayac = 0;

        static Islem()
        {
            Console.WriteLine("Static Contructor Çalılştı...!");
        }

        public Islem()
        {
            Console.WriteLine(sayac+".  Public Constructor Çalıştı...!");
            sayac++;
        }

    
         
    }
}
