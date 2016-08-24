using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace List_in_Class
{
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ModelYil { get; set; }
        public string Renk { get; set; }
        public string durum { get; set; }

        public Car(string mk, string ml, string mly, string r,string d)
        {
            Marka = mk;
            Model = ml;
            ModelYil = mly;
            Renk = r;
            durum = d;

            CarManager.ListCars.Add(this);
            
         }

    }
}
