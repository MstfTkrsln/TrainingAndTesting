using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    class Program
    {
        abstract class calc<T>
        {
            public virtual int hesapla(T digit)
            {
                return Convert.ToInt32(digit)+Convert.ToInt32(digit);
            }
            public virtual  string yaz(T s)
            {
                return s.ToString();
            }

           

        }

        class calc2 : calc<int>
        {
            
            public override int hesapla(int digit)
            {
                
                return digit;
            }

            public override string yaz(int s)
            {
                return (s*s).ToString();
            }


        }
        static void Main(string[] args)
        {
            calc<int> c=new calc<int>();
            Console.WriteLine(c.yaz(5));
            Console.ReadKey();

            calc<int> c2=new calc2();
            Console.WriteLine(c2.yaz(5));
            Console.ReadKey();
        }
    }
}
