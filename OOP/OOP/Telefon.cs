using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Telefon
    {
        internal string marka { private get; set; }
        internal string model { private get; set; }
        public override string ToString()
        {
            return marka + "   " + model;
        }
    }
}
