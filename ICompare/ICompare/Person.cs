using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICompare
{
    internal class Person : IComparable
    {
        private string Ad { get; set; }
        private string Soyad { get; set; }
        private int Yas { get; set; }

        public Person(string ad, string soyad, int yas)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
        }

        public int CompareTo(object obj)
        {
            Person p = (Person) obj;

            int sonuc = Yas.CompareTo(p.Yas);

            if (sonuc == 0)
            {
                sonuc = Ad.CompareTo(p.Ad);

                if (sonuc == 0)
                {
                    sonuc = Soyad.CompareTo(p.Soyad);
                }
            }
            return sonuc;

        }

        public override string ToString()
        {
            return Ad + " " + Soyad + " :" + Yas;
        }
    }
}
