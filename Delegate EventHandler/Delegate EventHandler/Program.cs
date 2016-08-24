using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Delegate_EventHandler
{
    class Program
    {
        public delegate void ClickEventHandler(string mesaj);

        //class CustomControl
        //{
        //    public event ClickEventHandler Click;

        //    public void OnClick(string Mesaj)
        //    {
        //        Click(Mesaj);
        //    }
        //}

        public static event ClickEventHandler Click;


        static void Main(string[] args)
        {
            //CustomControl c1=new CustomControl();
            
            
            Click+=new ClickEventHandler(MesajYaz);
            Click+=new ClickEventHandler(MesajBuyukYaz);

             Click("mustafa tekeraslan");
            Console.WriteLine();

            Click-=new ClickEventHandler(MesajYaz);
           Click("mustafa tekeraslan");
            Console.ReadLine();
        }

        static void MesajYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        private static void MesajBuyukYaz(string mesaj)
        {
            Console.WriteLine(mesaj.ToUpper());
        }

        class mesajargs:EventArgs
        {
             
        }
    }
}
