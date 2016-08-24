using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBindIslemleri
{
    public class Urun
    {
        public int Id;
        public string Ad;
        public double BirimFiyat;
        public int StokMiktari;
        public bool Durum;

        // Eğer ToString metodunu override etmessek, ItemsSource' a bu tip bağlandığında İsimAlanıAdı.TipAdı bilgisi gösterilir.
        public override string ToString()
        {
            return Id.ToString() + " " + Ad+" "+BirimFiyat.ToString();
        }
    }

    public class UrunListesi:List<Urun>
    {
        public UrunListesi()
        {
            Add(new Urun() { Id = 1, Ad = "Grafik Kartı", BirimFiyat = 35, StokMiktari = 100,Durum=true });
            Add(new Urun() { Id = 2, Ad = "Monitor", BirimFiyat = 150, StokMiktari = 50, Durum = false });
            Add(new Urun() { Id = 3, Ad = "CPU X86", BirimFiyat = 145, StokMiktari = 150, Durum = true });
            Add(new Urun() { Id = 4, Ad = "USB Bellek", BirimFiyat = 15, StokMiktari = 250, Durum = true });
            Add(new Urun() { Id = 5, Ad = "HDD 250 Gb", BirimFiyat = 250, StokMiktari = 14, Durum = false });
        }
    }
}
