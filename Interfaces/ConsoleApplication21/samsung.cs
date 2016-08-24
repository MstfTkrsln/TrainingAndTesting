using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    class samsung:Program.IBaslıklar,Program.IUzunluk
    {
        
        public string Isim()
        {
            return "Model :Galaxy S5";
        }

        public string Anabaslik()
        {
            return "Teknoloji";
        }

        public string Altbaslik()
        {
            return "Telefon";
        }
        
        public string En()
        {
            return "70,6mm";
        }

        public string Boy()
        {
            return "136,6mm";
        }

        public string Kalinlik()
        {
            return "8,6mm";
        }

        string Program.IUzunluk.Yazdir()
        {
            return "iuzunluk yazdır";
        }

        string Program.IBaslıklar.Yazdir()
        {
            return "ibasliklar yazdır";
        }
    }
}
