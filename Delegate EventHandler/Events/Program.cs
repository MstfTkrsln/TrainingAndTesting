using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Program
    {
        //Delegate Tanımlıyoruz
        public delegate string VardiyaDurumu();

        //Event Kaynak Sınıfımız
        class VardiyaEventCls
        {
            public event EventHandler test;
            
            //Event Tanımı
            public event VardiyaDurumu vardiyaEvt;
            public void vardiyaSorgula()
            {
                string durum = vardiyaEvt();
                Console.WriteLine("Bugünkü Vardiya" +" Durumunuz: {0}", durum);
            }
        }

        static void Main(string[] args)
        {
            VardiyaEventCls varEvt = new VardiyaEventCls();
            //VardiyaDurumu delegesiyle varEvt_Kontrol metodumuzu
            // referans alıyoruz ve bunuda event'a ekliyoruz
           
            varEvt.vardiyaEvt += new VardiyaDurumu(varEvt_Kontrol);
            //Aşağıdaki şekilde kullanımsa delegenin, olaydan(event)
            //çıkarılması sağlanır.
            // varEvt.vardiyaEvt -= new VardiyaDurumu(varEvt_Kontrol);

            Console.WriteLine("Bugünkü Vardiya Durumunuzu Öğrenmek" +
            " İçin Personel Numaranızı Giriniz");
            string numara = Console.ReadLine();
            //numarası 1 olan kişinin vardiyasını belirleyelim
            if (numara == "1")
            {
                //vardiyaSorgula metodu ile vardiyaEvt tetiklenmiş olur
                varEvt.vardiyaSorgula();
            }
            else
            {
                Console.WriteLine("Personel Numaranız Kayıtlı" +
                " Görünmüyor, Lütfen İnsan Kaynaklarıyla Görüşünüz");
            }
            Console.ReadLine();
        }

        

        static string varEvt_Kontrol()
        {
            //Günün Değeri Alınır
            string Bugun = DateTime.Now.DayOfWeek.ToString();
            string durum = "Belirsiz";
            switch (Bugun)
            {
                case "Monday":
                    durum = "Gece";
                    break;
                case "Tuesday":
                    durum = "Gündüz";
                    break;
                case "Wednesday":
                    durum = "Gece";
                    break;
                case "Thursday":
                    durum = "Gündüz";
                    break;
                case "Friday":
                    durum = "Gece";
                    break;
                case "Saturday":
                    durum = "Gündüz";
                    break;
                case "Sunday":
                    durum = "Yok, Tatil";
                    break;
            }
            return durum;
        }
    }
}
