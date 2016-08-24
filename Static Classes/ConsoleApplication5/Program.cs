using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{

        public class Dikdortgen
        {
            
            public static int kontrolAlani = 20;

            static Dikdortgen()
            {
                kontrolAlani = 10;
            }
            public void KontrolAlaniDegistir()
            {
                kontrolAlani = 40;
            }
            public static int AlanHesapla(int aKenari, int bKenari)
            {
                return aKenari * bKenari;
            }

            public bool AlanKontorlu(int aKenari, int bKenari, int kontrolAlani)
            {
                if (kontrolAlani > AlanHesapla(aKenari, bKenari))
                    return true;
                else
                    return false;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Dikdortgen dikdortgen1 = new Dikdortgen();
                Console.WriteLine(Dikdortgen.kontrolAlani);

                dikdortgen1.KontrolAlaniDegistir();

                Dikdortgen dikdortgen2 = new Dikdortgen();
                Console.WriteLine(Dikdortgen.kontrolAlani);

                Dikdortgen dikdortgen3 = new Dikdortgen();
                Console.WriteLine(Dikdortgen.kontrolAlani);

                Console.ReadLine();
            }
        }
    
}
