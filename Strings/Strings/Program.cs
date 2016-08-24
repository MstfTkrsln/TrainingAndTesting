using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace KartDagitim
{
    class Program
    {

public class KartGrup
    {
    public class Kart
    {
        private string Deger;  //kart değerini burada tutacağım
        private string Grup;   //kart grubunu da burada tutacağım
         
        //iki paremetreli constructor oluşturuyorum, 
        //buradaki değerler ile kartlarımı oluşturuyorum
        public Kart(string KartDeger, string KartGrup)
        {
            Deger = KartDeger;  //KartDegeri çalıştırılıyor
            Grup = KartGrup;    //KartGrubu çalıştırılıyor
        } //Burada kart constructor sonlanıyor
 
        //Aşağıdaki metodum ile kartın değerini yazdırıyorum
        public override string ToString()
        {
            return Grup + " " + Deger;
        } //ToString metodunu burada sonlandırıyorum
    } //Kart classı burada sonlanıyor
        private Kart[] KartGrubu; //Kart nesnesinden bir dizi oluşturuyorum
        private int GuncelKart; //KartGrubu dizisindeki elemanların indeksi için kullanacağım
        private const int Kart_Sayisi = 52; //Kartların toplam sayısını sabit bir değişkene aldım
        private Random RastgeleSayi; //Rastgele sayı oluşturmak için değişken oluşturdum
 
        //Kartların gruplarını oluşturmak için bir constructor yazıyorum
        public KartGrup()
        {
            //değerler dizisini ve gruplar dizisini oluşturuyorum
            string[] degerler = {"AS","İkili","Üçlü","Dörtlü","Beşli","Altılı","Yedili","Sekizli",
                                    "Dokuzlu","Onlu","Vale","Kız","Papaz"};
            string[] gruplar = { "Kupa", "Karo", "Sinek", "Maça" };
 
            //Kart sınıfımdan nesnemi alıyorum.
            KartGrubu = new Kart[Kart_Sayisi];
            GuncelKart = 0;
            RastgeleSayi = new Random();
 
            //Kartlarımı oluşturuyorum
            for (int sayac = 0; sayac < KartGrubu.Length; sayac++)
            {
                KartGrubu[sayac] = new Kart(degerler[sayac % 13], gruplar[sayac / 13]);
            }
        } //constructor sonu
 
        public void KartKaristir()
        {
            //Her karıştırma sonrası GuncelKart değerini sıfırdan başlatıyorum
            GuncelKart = 0;
 
            //her bir kart için rastgele karıştırma işlemi
            for (int birinci = 0; birinci < KartGrubu.Length; birinci++)
            {
                //0 ile 51 arasında rastgele sayı oluşturuyorum
                int ikinci = RastgeleSayi.Next(Kart_Sayisi);
 
                //GuncelKart değerini rastgele seçilen kart değeri ile değiştiriyorum
                Kart gecici = KartGrubu[birinci];
                KartGrubu[birinci] = KartGrubu[ikinci];
                KartGrubu[ikinci] = gecici;
            }
             // for döngüsü sonu
        } //KartKaristir metodu sonu
 
        //Kart paylaştırma metodum
        public Kart KartPaylas()
        {
            if (GuncelKart < KartGrubu.Length)
                return KartGrubu[GuncelKart++]; //dizideki güncelkart değerini geri döner
            else
                return null;
        } //KartPaylas metodu sonu
    }


        public static void Main(string[] args)
        {
            KartGrup kartlarimiz = new KartGrup();
            kartlarimiz.KartKaristir();
 
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,-19}", kartlarimiz.KartPaylas());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
 
            Console.ReadLine();
        }
    }
}