using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using Pluggable.Attributes;
using Pluggable.Interfaces;
using Pluggable;
using PluggableCoreLibrary;

namespace PluggableHostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                x = 10,
                y = 5;

            Console.WriteLine(String.Format("x={0} y={1}", x.ToString(), y.ToString()));

            foreach (CalculatorHost calculator in CalculatorHostProvider.Calculators)
            {
                calculator.X = x;
                calculator.Y = y;
                Console.WriteLine(calculator.ToString());
            }

            Console.ReadLine();
        }
    }
}
