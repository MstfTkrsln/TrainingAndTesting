using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Reflection_of_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof (Matematik);

            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.BaseType);

            MemberInfo[] uyeler = t.GetMembers();
            Console.WriteLine("\n*********************\n");

            foreach (MemberInfo m in uyeler)
            {
                Console.WriteLine(m.DeclaringType +"\t"+m.MemberType+"\t"+m.Name);
            }
            Console.ReadLine();
        }
    }
}
