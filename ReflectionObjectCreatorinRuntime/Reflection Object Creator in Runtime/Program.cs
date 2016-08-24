using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection_Object_Creator_in_Runtime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir tip adı giriniz");
            string tipAdi = Console.ReadLine();//Double,Int32 vs..

            Type tip = Type.GetType("System."+tipAdi);
            object obj = Activator.CreateInstance(tip);

            Console.WriteLine(obj == null ? "Nesne oluşturulamadı." : "Nesne dinamik olarak örneklendi");
            
            Console.WriteLine("\nMembers\n");
            foreach (var VARIABLE in tip.GetMembers())
            {
                Console.WriteLine(VARIABLE.Name);
            }
           
            
            Console.ReadLine();

        }
    }
}
