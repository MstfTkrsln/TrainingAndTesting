using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        class liste<T>
        {
            public void ekle(T deger)
            {
                int i=0;
                
                T[] dizi=new T[10];
                dizi[i] = deger;
                Console.WriteLine(dizi[i]);
                   i++;
                
            }
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("eleman  :");
            int deger=Convert.ToInt32(Console.ReadLine());
            liste<Int32> listem=new liste<Int32>();
            listem.ekle(deger);

            Console.WriteLine("eleman  :");
            string deger2=Console.ReadLine().ToString();
            liste<string> listem2=new liste<string>();
            listem2.ekle(deger2);
            Console.ReadLine();

        }

   }
    
}
