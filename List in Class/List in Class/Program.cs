using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_in_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight += Console.WindowHeight / 2;
            Console.Title = "Cars";
           
            Console.ForegroundColor = ConsoleColor.Magenta;
            CarManager CM=new CarManager();
            Console.ReadLine();

            
        }
    }
}
