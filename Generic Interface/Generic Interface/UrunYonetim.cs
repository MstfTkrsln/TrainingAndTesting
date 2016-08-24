using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Interface
{
    class UrunYonetim:IEnumerable<Urun>
    {
        private Urun[] Urunler { get; set; }

        private Urun[] UrunleriGetir()
        {
            return new Urun[] {new Urun(1, "Monitör", 200), new Urun(2, "klavye", 80), new Urun(3, "Mouse", 40)};
        }

        public UrunYonetim()
        {
            Urunler = UrunleriGetir();
        }
        public IEnumerator<Urun> GetEnumerator()
        {
            for (int i = 0; i < Urunler.Length; i++)
            {
               yield return Urunler[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
