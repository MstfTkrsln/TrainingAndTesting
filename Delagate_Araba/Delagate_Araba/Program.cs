using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Delagate_Araba
{
    class Program
    {
        private delegate void Hizasimihandler();

        class Araba
        {
            public Hizasimihandler hizasimi=new Hizasimihandler(araba_hizasimi);

            
            private int hiz;
            private string model;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public int Hiz
            {
                get { return hiz; }
                set
                {
                    hiz = value;
                    if (hiz > 120)
                        hizasimi();
                }
            }

            public Araba(int hiz, string model)
            {
                this.Hiz = hiz;
                this.Model = model;
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Araç Hızı     : ");
            int Ahiz=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araç Modeli   : ");
            string Amodel = Convert.ToString(Console.ReadLine());

            Araba araba = new Araba(Ahiz,Amodel);
           

            araba.hizasimi += araba_hizasimi;
            
            araba.Hiz = Ahiz;
            araba.Model = Amodel;
            

            Console.ReadLine();
        }

        static void araba_hizasimi()
        {
            
            
            Console.WriteLine("120 km üstüne çıktınız...");
            
        }
    }
}
