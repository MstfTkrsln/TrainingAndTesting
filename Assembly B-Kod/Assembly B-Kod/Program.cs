using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.Hosting;
using System.Runtime.Serialization;
using System.Text;

namespace Assembly_B_Kod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WindowHeight = 80;
            Console.WindowTop = 5;
            Console.BufferHeight = 1000;//Eski Type'ların hala ekranda görünmesi için.

            Assembly asm = Assembly.LoadFrom(@"edtftpnet.dll");


            Type[] Turler = asm.GetTypes();
            
            
            Console.WriteLine("Tur Sayısı  :  "+Turler.Length);

            foreach (Type t in Turler)
            {
                Console.WriteLine("\n*********{0}  Bilgileri***********\n",t.FullName);
                Console.WriteLine(t.Name);
                Console.WriteLine(t.IsClass);
                Console.WriteLine(t.IsEnum);
                Console.WriteLine(t.IsPublic);
                Console.WriteLine(t.Attributes);

                foreach (ConstructorInfo c in t.GetConstructors())
                {
                    Console.WriteLine("\t {0}",c.MemberType);
                    Console.WriteLine("\t {0}", c.Name);
                }
            }

       
            Console.ReadLine();
        }
    }
}
