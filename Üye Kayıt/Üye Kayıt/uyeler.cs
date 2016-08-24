using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Üye_Kayıt
{
    class uyeler
    {
        private int _uyeno; 
        public int UyeNo
        {
            get { return _uyeno; }
            set { _uyeno = value; }
        }
 
        private string _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
 
        private string _soyad;
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
 
        private DateTime _uyedogumtarih;
        public DateTime UyeDogumTarih
        {
            get { return _uyedogumtarih; }
            set { _uyedogumtarih = value; }
        }
 
        private string _cinsiyet;
        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }
 
        private DateTime _uyeliktarihi;
        public DateTime UyelikTarihi
        {
            get { return _uyeliktarihi; }
            set { _uyeliktarihi = value; }
        }
 


        public override string ToString()
        {
            return this.UyeNo + " " + this.Ad + " " + this.Soyad + " " +
                   this.UyelikTarihi.ToLongDateString() + " " +
                   this.Cinsiyet + " " + this.UyelikTarihi.ToLongDateString();
        }
    }
}
