using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct_Customer
{
    class Program
    {

        struct Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            Customer c1 = new Customer {Id=1, Name = "mustafa"};

            Customer c2 =  c1;

            c2.Id = 2;
            c2.Name = "Kamil";

            Console.WriteLine("C1 ID ="+c1.Id+"  C1 Name ="+c1.Name);
            Console.WriteLine("C2 ID =" + c2.Id + "  C2 Name =" + c2.Name);

            //class olsaydı adresleri eşitlenecek ve aynı sonuç üretüretilecekti.

            Console.ReadLine();

        }
    }
}
