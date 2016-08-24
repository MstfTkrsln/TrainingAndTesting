using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oto_Kiralama
{
    public class Araba
    {
      
        public string Marka
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public int Yıl
        {
            get;
            set;
        }

        public string Renk
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Marka + " " + Model + " " + Yıl + " " + Renk;
        }

        public void Remove()
        {
            Marka = null;
            Model = null;
            Renk = null;
            Yıl = 0;
        }
    }
}
