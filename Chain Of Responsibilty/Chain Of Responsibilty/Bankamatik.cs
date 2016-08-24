using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    public class Bankamatik
    {
        Para200 _200 = new Para200();
        Para100 _100 = new Para100();
        Para50 _50 = new Para50();
        Para20 _20 = new Para20();
        Para10 _10 = new Para10();
        Para5 _5 = new Para5();


        public void ParaCek(int tutar)
        {
            Console.WriteLine("Toplam Tutar: " + tutar);

            _200.Sonraki(_100);
            _100.Sonraki(_50);
            _50.Sonraki(_20);
            _20.Sonraki(_10);
            _10.Sonraki(_5);

            Miktar sonuc = new Miktar();
            List<Miktar> sonuclar = new List<Miktar>();

            do
            {
                sonuclar.Add(sonuc = _200.ParaCek(tutar));
                tutar = sonuc.Kalan;
            } while (sonuc.Kalan > 0);

            foreach (var s in sonuclar)
            {
                Console.WriteLine("Tutar: " + s.Tutar + "\tAdet: " + s.Adet);
            }

         
        }
    }
}
