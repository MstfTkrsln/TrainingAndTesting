using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> list=new List<char>();
            char x=new char();
            string[] cumle=new string[20];

            x = Console.ReadKey().KeyChar;
            while (x != Convert.ToChar(ConsoleKey.Escape)) 
            {
                Console.WriteLine();
                Console.WriteLine("Tuş : " + x + "  listeye eklendi !");
                list.Add(x);
                x = Console.ReadKey().KeyChar;
                

            }
            Console.WriteLine("***** LİSTE *****");
            for (int i = 0; i < list.Count; i++)
            {
                
                cumle[i] = list[i].ToString();
                Console.WriteLine(" "+i+". :\t"+list[i]);
            }

            Console.ReadKey();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(cumle[i]);

            }
            Console.ReadKey();
        }
    }
}
