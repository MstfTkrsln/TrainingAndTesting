using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    public delegate void Multicastornek(int a,int b,char x);

    public class Islem
    {
        public static void Toplama(int a, int b,char x)
        {
            if(x=='+')
        Console.WriteLine("Toplama İşlemi  : {0} + {1} = {2} ",a,b,a+b);
        }

        public static void Cikarma(int a, int b,char x)
        {
            if (x=='-')
            Console.WriteLine("Çıkarma İşlemi : {0} - {1} = {2} ",a,b,a-b);
        }
        public static void Carpma(int a, int b,char x)
        {
            if (x=='*')
            Console.WriteLine("Çarpma İşlemi : {0} * {1} = {2} ", a, b, a * b);
        }
        public static void Bolme(int a, int b,char x)
        {
            if (x=='/')
            Console.WriteLine("Bolme İşlemi : {0} / {1} = {2} ", a, b, a/b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Multicastornek ornek = Islem.Toplama;
            ornek += Islem.Cikarma;
            ornek += Islem.Carpma;
            ornek += Islem.Bolme;

            Console.Write("Birinci Sayıyı giriniz  : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı giriniz   : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlemi giriniz [+,-,/,*]   : ");
            char x = Convert.ToChar(Console.ReadLine());

            ornek(a,b,x);

           
            
            
            Console.ReadKey();

        }
    }
}
