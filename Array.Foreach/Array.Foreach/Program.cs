using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Array_Foreach
{
    class Program
    {
        public static void Main()
    {
        // create a three element array of integers 
        int[] intArray = new int[] {2, 3, 4, 5, 6};

        // set a delegate for the ShowSquares method
        Action<int> action = ShowSquares;

        Array.ForEach(intArray,action);
            Console.ReadLine();
    }

    private static void ShowSquares(int val)
    {
        Console.WriteLine("{0} squared = {1}", val,  
             val*val);
    }
    }
}
