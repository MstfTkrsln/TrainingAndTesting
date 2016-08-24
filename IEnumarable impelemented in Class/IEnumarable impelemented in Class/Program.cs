using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IEnumarable_impelemented_in_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1=new Kisi("Mustafa TEKERASLAN",26);
            Kisi kisi2 = new Kisi("Kamil SÖNMEZ", 21);
            Kisi kisi3 = new Kisi("Cemil AKDEMİR", 30);

            Kisiler KisiKayitlar=new Kisiler();
            KisiKayitlar.Add(kisi1);
            KisiKayitlar.Add(kisi2);
            KisiKayitlar.Add(kisi3);

            foreach (Kisi item in KisiKayitlar)
            {
                Console.WriteLine(item.Adsoyad+" >> "+item.Yas);
            }

            Console.WriteLine("**************");
            //veya

            IEnumerator _kisiEnumerator = KisiKayitlar.GetEnumerator();
            while (_kisiEnumerator.MoveNext())
            {
                Kisi _kisi = (Kisi) _kisiEnumerator.Current;
                Console.WriteLine(_kisi.Adsoyad+"  "+_kisi.Yas);
            }

            
            Console.ReadLine();
        }


        public class Kisi
        {
            public string Adsoyad { get; set; }
            public int Yas { get; set; }

            public Kisi(String _adsoyad, int _yas)
            {
                Adsoyad = _adsoyad;
                Yas = _yas;
            }

        } 



        public class Kisiler :IEnumerable
        {
             private ArrayList KisiList=new ArrayList();

            public Kisi this[int index]
            {
                get { return (Kisi) KisiList[index]; }
                set { KisiList[index] = value; }
            }

            public void Add(Kisi _kisi)
            {
                KisiList.Add(_kisi);
            }

            public int count
            {
                get { return KisiList.Count; }
            }
            public IEnumerator GetEnumerator()
            {
                //for (int i = 0; i < KisiList.Count; i++)
                //{
                //   yield return KisiList[i];
                //}
                //böylede kullanabiliriz yield burda iterasyon işlemini yapar ve ienumerator class a gerek kalmaz..

                return new KisiEnumerator(this);

            }
        }



        public class KisiEnumerator : IEnumerator
        {
            private int index = -1;
            private Kisiler oKisiler;

            public KisiEnumerator(Kisiler _kisiler)
            {
                oKisiler = _kisiler;
            }

            public object Current
            {
                get
                {
                    if (index > -1)
                    {
                        return oKisiler[index];
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            public bool MoveNext()
            {
                index++;
                if (index < oKisiler.count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {

                index = -1;
            }
        }
    }
}
