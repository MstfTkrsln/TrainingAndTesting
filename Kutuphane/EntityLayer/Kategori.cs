using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class Kategori:IDisposable
    {
        private int _ID;

        private string _ADI;


        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string ADI
        {
            get { return _ADI; }
            set { _ADI = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            
        }

        public override string ToString()
        {
            return ADI;
        }
    }
}
