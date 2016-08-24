using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection_of_Class
{
    class Matematik
    {
        private int sayi1;
        private int sayi2;

        public int Sayi1 { get { return sayi1;} set { sayi1 = value; } }
        public int Sayi2 { get { return sayi2;} set { sayi2 = value; } }

        public Matematik(int _sayi1,int _sayi2)
        {
            Sayi1 = _sayi1;
            Sayi2 = _sayi2;
        }

        public int Toplama()
        {
            return sayi1+sayi2;

        }

        public int Cikarma()
        {
            return Sayi1 - Sayi2;
        }
    }
}
