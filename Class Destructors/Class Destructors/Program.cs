using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Destructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba=new Araba(0);

            for (int i = 0; i < 100; i++)
            {
                araba.Nesneolustur(i);
            }
            Console.WriteLine("Main() metodu sonlanmıştır. ");
            Console.ReadLine();

        }

        class Araba
        {
            private int sayac;

            public Araba(int x)
            {
                sayac = x;
            }

            public void Nesneolustur(int x)
            {
                Araba araba=new Araba(x);
            }


            ~Araba()
            {
                Console.WriteLine("{0} nolu Araba nesnesi yok ediliyior.",sayac);
            }
        }
    }
}
