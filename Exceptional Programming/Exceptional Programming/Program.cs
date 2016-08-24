using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 84;
            Console.WindowTop=0;
            Console.WriteLine("**********EXCEPTİONAL PROGRAMMING**********");
            Console.WriteLine();

            try
            {
                ClassArgument classArgument = new ClassArgument(3);
                
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();
            }

            try
            {
                ClassFileNotFound classFileNotFound = new ClassFileNotFound();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();
            }
            
            try
            {
                ClassArrayTypeMismatch classArrayTypeMismatch=new ClassArrayTypeMismatch();
            }
            catch (ArrayTypeMismatchException ex)
            {
               
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();
            }
            try
            {
                ClaassNullReferenceException claassNullReferenceException = new ClaassNullReferenceException();
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();
            }
            try
            {
             ClassFormatException classFormatException=new ClassFormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();               
                
            }
            try
            {
            ClassInvalidOperation classInvalid=new ClassInvalidOperation();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();                 
                
            }
            try
            {
            ClassKeyNotFound classKeyNotFound=new ClassKeyNotFound();
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();                             
            }

            try
            {
            ClassStackOverflow classStackOverflow=new ClassStackOverflow();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();     
                
            }
           
           


            Console.ReadLine();
        }
    }
}
