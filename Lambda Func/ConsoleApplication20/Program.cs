using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
  

        static void Main(string[] args)
        {
            //lambda func
            Func<int, string> f = sayi =>{if (sayi < 10)return "küçük";else return "büyük";};
            Func<int, string> f2 = sayi => { if (sayi < 10)return "küçük"; else return "büyük"; };
            Console.WriteLine(f(10));
            Console.WriteLine(f(1));

            Console.ReadKey();
            
        }
    }
}
