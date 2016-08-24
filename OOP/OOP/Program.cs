using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Telefon tlf=new Telefon()
            
            tlf.marka = "nokia"; 
            tlf.model = "lumnia";
           
           
            Console.WriteLine(tlf.ToString());
            Console.ReadKey();
        }
    }
}
