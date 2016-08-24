using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons=new Person[3];

            persons[0] = new Person("Ali", "Yılmaz", 15);
            persons[1] = new Person("Veli", "Sert", 13);
            persons[2] = new Person("Mustafa", "Kaya", 11);
            

            Array.Sort(persons);

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i]);
            }
            Console.ReadKey();
        }
    }
}
