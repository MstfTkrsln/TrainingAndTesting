using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using Interpress.Library.Extensions;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //for (int i = 0; i < 100000000; i++)
            //{
                
            //    List<Person> persons = new List<Person>();

            //    if (i == 500000)
            //        Console.WriteLine("50000000");

            //    Person p=new Person();
            //    persons.Add(p);
                
            //    if (i == 100000000-1)
            //        Console.WriteLine("50000000");
            //}
            
            Person p=new Person();
            p.ad = "Mustafa";
            p.id = 12345;

            int test = 1;
            Console.WriteLine("İlk Değer  :"+p.ad+" :"+p.id);

            var newP= changeAd(p);

            Console.WriteLine("Method Dönüşü Person Değer :" + newP.ad + " :" + newP.id);




            Console.WriteLine("Eski Person Değer :" + p.ad + " :" + p.id);


            Console.WriteLine("Sonra :"+ChangeInt( test));
            Console.WriteLine("İlk :" + test);
            

            Person p1=new Person(){ad = "Bir", id = 1};

            Person p2=new Person();

 //Ext.DeepCopyTo(p1, p2);

            p2 = p1;
            p2.ad = "İki";
            p2.id = 2;

            Console.WriteLine("P1     :"+p1.ad + " " + p1.id);
            Console.WriteLine("P2     :"+p2.ad+" "+p2.id);
            
            Console.ReadKey();

            
            

        }

        public static Person changeAd( Person p)
        {
       
            p.ad = "324";
            p.ad = "Method Değişti";
            p.id = 0;
            return p;
        }

        public static int ChangeInt( int s)
        {
            s = 0;

            return s;
        }
    }

    class Person
    {
        public string ad;
        public long id;

       
        
    }
}
