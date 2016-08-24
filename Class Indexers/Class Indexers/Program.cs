using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Uye ClsUye=new Uye();

            Console.WriteLine("Uye Sınıfınıj 3. Üyesi : "+ClsUye[2]);
            Console.ReadLine();

        }
    }
}
