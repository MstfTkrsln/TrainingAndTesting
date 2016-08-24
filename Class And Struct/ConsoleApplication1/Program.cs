using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
         public class cls
         {
             public int sayi2;
                public int kare(int sayi)
                {
                    sayi2 = sayi*sayi;
                return sayi2;
            }
            
            }

         struct stc
         {
             public int sayi2;
            public int kare(int sayi)
            {
                sayi2 = sayi*sayi;
                return sayi2;

            }
        }

        static void Main(string[] args)
        {
            stc kareals = new stc();
            cls karealc=new cls();



            Console.Write("Karesi alınacak sayıyı giriniz :");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("class : sayi * sayi = "+ karealc.kare(sayi));
            

            
            Console.Write("Karesi alınacak sayıyı giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("class : sayi * sayi = " + kareals.kare(sayi));

            Console.ReadKey();

        }
    }
}
