using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ExceptionCreating
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Array[] dizi = null;
                Array[] dizi2 = new Array[101];
                ClassArray ca = new ClassArray(dizi);
            }
            catch (ClassArray.DiziNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ClassArray.DiziTasmaException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
            ClassString cs=new ClassString(null);
            }
            catch (ClassString.stringException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
            
        }
       
    }
}
