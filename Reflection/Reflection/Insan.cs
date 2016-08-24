using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    class Insan
    {
        string adi;
        string soyadi;
        string websitesi;

        public string Websitesi
        {
            get { return websitesi; }
            set { websitesi = value; }
        }

        public string Soyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        public void ekranaYazdir(string gelenDeger)
        {
            Console.WriteLine(gelenDeger);
            Console.WriteLine("\nAdi:" + adi + "\nSoyadi: " + soyadi + "\nWebsitesi: " + websitesi);
        }
    }
}
