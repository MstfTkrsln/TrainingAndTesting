using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfBook7
{
    class Akademisyen
    {
        public string Kadro { get; set; }

        public string AdSoyad { get; set; }

        public int Id { get; set; }

        public Akademisyen(int _id,string _kadro,string _adsoyad)
        {

            Id = _id;
            Kadro = _kadro;
            AdSoyad = _adsoyad;
        }
    }
}
