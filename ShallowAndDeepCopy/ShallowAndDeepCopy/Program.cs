using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;

namespace ShallowAndDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1=new Product();
            
            p1.name="Monitor";
            p1.id = 101234;
            p1.dates=new productDate(new DateTime(2010,01,01),new DateTime(2014,01,01));
          
            ProductInformation(p1);
            Product shallowProduct= Product.ShallowCopy(p1);
            Product deepProduct=Product.DeepCopy(p1);
            Product deepserialize = p1.deepCopySerializable();
            ProductInformation(shallowProduct);
            ProductInformation(deepProduct);
            ProductInformation(deepserialize);


            p1.name = "New Name";
            p1.id = 10000000000000;
            p1.dates.productionDate=new DateTime(1000,01,01);
            p1.dates.ExpirationDate=new DateTime(1001,01,01);

            Console.WriteLine("\n After Copies \n");

            ProductInformation(p1);
            ProductInformation(shallowProduct);
            ProductInformation(deepProduct);
            ProductInformation(deepserialize);


            Console.ReadLine();
        }

        

        public static void ProductInformation(Product p)
         {

            Console.WriteLine(p.name);
            Console.WriteLine(p.id);
            Console.WriteLine(p.dates.productionDate.ToShortDateString());
            Console.WriteLine(p.dates.ExpirationDate.ToShortDateString());
            Console.WriteLine("*************************************");
                
         }
    }
}
