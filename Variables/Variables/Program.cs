using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            float fdeger = 10.4F;
            double ddeger = fdeger;
            decimal decdeger =(decimal) fdeger;

            Console.WriteLine(fdeger + "  " + ddeger+" "+ decdeger);
            int? x = null;
            int y = x.GetValueOrDefault(10);

            Console.WriteLine("x:  "+x);
            Console.WriteLine("y:  "+y);

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Pow(y,2)); //y kare

            int val = 10;
            int val2 = val++;

            Console.WriteLine("val :"+val+" val2 :"+val2);//aktarıp artırdı

            int bit1 = 5;  //101
            int bit2 = 3;  //011
                     
            Console.WriteLine(bit1 & bit2);//sonuc 001
            Console.WriteLine(bit1 | bit2);//sonuc 111

            Console.WriteLine(bit2<<1);//kaydırma sola bir adım yani 110 oldu

            // ? operatörü

            bit2 = (bit1 == 5) ? 25 : 0;
            Console.WriteLine("bit2 :"+bit2); //25 olur

            //is and as
            object obj1 = 32;
            object obj2 = "mustafa";

            Console.WriteLine("obj1  :"+obj1.GetType());
            Console.WriteLine("obj2  :"+obj2.GetType());
            
            //obj2 = obj1 as string; //string yapamadığı için null atar
                Console.WriteLine("obj2 before is"+obj2.GetType());
            if(obj2 is string
                )// obj2 stringe dönüştürmeye çalışır yaparsa true yapamazsa false döner.
            {
                Console.WriteLine("obj2 after is"+obj2.GetType());
            }
            else
            {
                Console.WriteLine("obj2 null'dur.");
            }



            //checked opertaörü taşmaları kontrol eder.
            int sayi = 260; 
            byte sayi2 = (byte) sayi;
            Console.WriteLine("sayi2  :"+sayi2); //taştı ve 4 oldu

            //checked
            //{
            //    sayi2 = (byte) sayi; //kontrol eder ve hata verir
            //}
            Console.WriteLine();



            string[] ogrenci=new string[2];

            ogrenci.SetValue("mustafa", 0);
            ogrenci.SetValue("tekeraslan", 1);
            Console.WriteLine(ogrenci.GetValue(0)+" "+ogrenci[1]);

            Console.WriteLine(Array.BinarySearch(ogrenci,"tekeraslan"));


            Console.ReadLine();
        }
    }
}
