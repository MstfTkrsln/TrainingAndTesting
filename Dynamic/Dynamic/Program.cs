using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic rakam = 10;

            Console.WriteLine(rakam.GetType());

            rakam += 10;

            Console.WriteLine(rakam);



            dynamic ad = 10;
            dynamic soyad = 20;

            //AdSoyadYaz(ad, soyad); Runtime error not compiie if you use object it will compile error




            


            var testvar = "abc";
            Console.WriteLine(testvar.Length);




            string teststring = "abc";
            Console.WriteLine(teststring.Length);

            dynamic s = "abc";
            Console.WriteLine(s.Length);
            Console.WriteLine(s);
            test(testvar);
            


            Console.ReadLine();
        }
        

        static internal void test(dynamic s)
        {
            
        }
        public static void AdSoyadYaz(string Ad, string Soyad)
        {
            Console.WriteLine(Ad + " " + Soyad);
        }

    }

    
}
