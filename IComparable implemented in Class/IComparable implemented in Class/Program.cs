using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_implemented_in_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Kisi> Kisiler=new List<Kisi>();

            Kisiler.Add(new Kisi("Mustafa",26));
            Kisiler.Add(new Kisi("Kamil",23));
            Kisiler.Add(new Kisi("Beykan",12));

            Console.WriteLine("***Before Sorting***");
            foreach (Kisi item in Kisiler)
            {
                Console.WriteLine(item.Adsoyad+" "+item.Yas);
            }
            Console.WriteLine();
            Kisiler.Sort();
            
            Console.WriteLine("***Sorting by Age***");
            foreach (Kisi item in Kisiler)
            {
                Console.WriteLine(item.Adsoyad + " " + item.Yas);
            }

            Console.ReadLine();
        }

        public class Kisi:IComparable<Kisi>
        {
            public string Adsoyad { get; set; }
            public int Yas { get; set; }

            public Kisi(String _adsoyad, int _yas)
            {
                Adsoyad = _adsoyad;
                Yas = _yas;
            }


            public int CompareTo(Kisi other)
            {
                return Yas.CompareTo(other.Yas);
            }

        } 
    }
}
