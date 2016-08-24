using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Indexers
{
    class Uye
    {
        private string[] uyeler={"Mustafa","Ali","Veli"};

        public string this[int index]
        {
            get { return uyeler[index]; }
            set { uyeler[index] = value; }
            
        }

    }
}
