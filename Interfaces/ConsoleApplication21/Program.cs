using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    class Program
    {
        public interface IBaslıklar
        {
            string Isim();
            string Anabaslik();
            string Altbaslik();
            string Yazdir();


        }

        public interface IUzunluk
        {
            string En();
            string Boy();
            string Kalinlik();
            string Yazdir();


        }
        static void Main(string[] args)
        {
            samsung s3=new samsung();
            IBaslıklar Baslik = (IBaslıklar) s3;
            IUzunluk Uzunluk = (IUzunluk) s3;
            
            Console.WriteLine(s3.Isim());
            Console.WriteLine(s3.Anabaslik());
            Console.WriteLine(s3.Altbaslik());
            Console.WriteLine(Baslik.Yazdir());
            Console.WriteLine();
            Console.WriteLine(s3.En());
            Console.WriteLine(s3.Boy());
            Console.WriteLine(s3.Kalinlik());
            Console.WriteLine(Uzunluk.Yazdir());
            Console.ReadKey();
        }
    }
}
