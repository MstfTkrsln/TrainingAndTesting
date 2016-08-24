using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            object nesnemiz;

            nesnemiz = new Insan();

            nesnemiz.GetType().GetProperty("Adi").SetValue(nesnemiz, "Mustafa", null);

            nesnemiz.GetType().GetProperty("Soyadi").SetValue(nesnemiz,"Tekeraslan",null);

            nesnemiz.GetType().GetProperty("Websitesi").SetValue(nesnemiz,"www.must.com",null);

            nesnemiz.GetType().GetMethod("ekranaYazdir").Invoke(nesnemiz, new object[]{"Insan Nesnesi"});

            Console.WriteLine("\nGet Properties\n");

            foreach (var item in nesnemiz.GetType().GetProperties())
            {
                Console.WriteLine(item.MemberType);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.PropertyType);
                Console.WriteLine(item.GetValue(nesnemiz,null));

                Console.WriteLine();
            }

            Console.WriteLine("\n Get Methods\n");
            foreach (var item in nesnemiz.GetType().GetMethods())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ReturnType);
                Console.WriteLine("\tParameters");
                foreach (var par in item.GetParameters())
                {
                    Console.WriteLine("\t"+par.Name);
                }
                Console.WriteLine();
            }


            

            Console.ReadLine();


        }
    }
}
