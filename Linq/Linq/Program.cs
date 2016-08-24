using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOrnek
{
    internal class Program
    {
        public class Ogrenci
        {
            public kisilikBilgileri kisilikBilgileri = new kisilikBilgileri();
            public dersNotlari dersNotlari = new dersNotlari();
        }

        public class dersNotlari
        {
            public List<decimal> notlar = new List<decimal>();
        }

        public class kisilikBilgileri
        {
            public string adi;
            public string soyadi;
            public string tcKimlikNo;
        }

        private static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            //ogrenciler listemize rastgele iki öğrenci tanımlayalım

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.kisilikBilgileri.adi = "Ali";
            ogrenci.kisilikBilgileri.soyadi = "Bal";
            ogrenci.kisilikBilgileri.tcKimlikNo = "40055588899";
            ogrenci.dersNotlari.notlar = new List<decimal> {52, 65, 75};
            ogrenciler.Add(ogrenci);

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.kisilikBilgileri.adi = "Emel";
            ogrenci2.kisilikBilgileri.soyadi = "Kaya";
            ogrenci2.kisilikBilgileri.tcKimlikNo = "9998888777";
            ogrenci2.dersNotlari.notlar = new List<decimal> {95, 82, 100};
            ogrenciler.Add(ogrenci2);

            //şimdi de linq ile öğrencilerin ortalamalarını ve isimlerini listeleyelim

            var ogrenciBilgileri = from ogrenciKaydi in ogrenciler
                orderby ogrenciKaydi.dersNotlari.notlar.Average() descending 
                //ascending kullanılırsa tam tersi şekilde sıralar
                select new
                {
                    OgrenciAdi = ogrenciKaydi.kisilikBilgileri.adi,
                    OgrenciSoyadi = ogrenciKaydi.kisilikBilgileri.soyadi,
                    OgrenciTcKimlik = ogrenciKaydi.kisilikBilgileri.tcKimlikNo,
                    OgrenciNotOrtalamasi = ogrenciKaydi.dersNotlari.notlar.Average()
                    // ortalama almamızı sağlayan metodumuz
                };

            //şimdi de öğrencilerimizi listeleyelim

            foreach (var ogrenciKaydi in ogrenciBilgileri)
            {
                Console.WriteLine("Ogrenci Adi: {0}", ogrenciKaydi.OgrenciAdi);
                Console.WriteLine("Ogrenci Soyadi: {0}", ogrenciKaydi.OgrenciSoyadi);
                Console.WriteLine("Ogrenci Tc Kimlik No: {0}", ogrenciKaydi.OgrenciTcKimlik);
                Console.WriteLine("Ogrenci Not Ortalamasi: {0}", ogrenciKaydi.OgrenciNotOrtalamasi);
                Console.WriteLine("---------------------------");
            }
            Console.ReadKey();
        }
    }
}