using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Methods
{
    class Program
    {
        private delegate T del<T>(T i);

        static void Main(string[] args)
        {
            del<Int16> delegem = delegate(Int16 k) { return (short)(k + k); };
            del<string> delegem2 = delegate(string k) { return (k + k); };

            Console.WriteLine("Hangi tip ile değer gireceksiniz...\n 1- Sayı \n 2- Metin");
            int sorgu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir değer giriniz...");
            switch (sorgu)
            {
                case 1:
                        Console.WriteLine(delegem((Convert.ToInt16(Console.ReadLine()))));
                        break;
                case 2:

                        Console.WriteLine(delegem2((Console.ReadLine())));
                        break;
                 default: 
                        Console.WriteLine("Yanlış bir değer girdiniz...!");
                    
                    break;

            }
            Console.ReadLine();
            }
    }
}
