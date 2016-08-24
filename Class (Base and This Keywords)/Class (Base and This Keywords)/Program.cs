using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class__Base_and_This_Keywords_
{
    class Program
    {
        static void Main(string[] args)
        {
            new TuremisSinif();
            Console.WriteLine("*********Garbage Collector**********");
            GC.Collect();
            Console.ReadLine();
            
        }
    }


    class TemelSinif
    {
        public TemelSinif(int x) : base()
        {
            Console.WriteLine("Değeri {0} olan int türünde parametre alan cons çağırıldı.",x);
        }

        ~TemelSinif()
        {
            Console.WriteLine("Remove Temelsinif");
        }
         
    }

    class TuremisSinif:TemelSinif
    {
        public TuremisSinif():this(7)
        {
            Console.WriteLine("Türemiş Sınıfta parametresiz alan cons");
        }

        public TuremisSinif(int y):base(y+1)
        {
            Console.WriteLine("Türemiş Sınıfta int türünde parametre alan cons");
        }

        public TuremisSinif(string s):base(12)
        {
            Console.WriteLine("Türemiş Sınıfta string türünde parametre alan cons");
        }
        ~TuremisSinif()
        {
            Console.WriteLine("Remove Türemişsinif");
        }
    }


}
