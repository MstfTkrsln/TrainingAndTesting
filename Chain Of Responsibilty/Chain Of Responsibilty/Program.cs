using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankamatik bank = new Bankamatik();

            Console.WriteLine("****************BANK****************\n\n");
            Console.Write("Çekmek İstedeğiniz Tutarı Griniz : ");
            
            int Nakit=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            bank.ParaCek(Nakit);


            Console.ReadKey();
        }
    }
}
