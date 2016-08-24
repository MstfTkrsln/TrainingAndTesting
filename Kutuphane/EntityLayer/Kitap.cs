using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class Kitap:IDisposable
    {
        private int _ID;
        private string _ADI;
        private string _YAZAR;
        private short _SAYFASAYISI;
        private int _KATEGORIID;
        private DateTime _GMT;
        private string _HOSTNAME;
        private string _KategoriAdi;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string ADI
        {
            get { return _ADI; }
            set { _ADI = value; }
        }

        public string YAZAR
        {
            get { return _YAZAR; }
            set { _YAZAR = value; }
        }

        public short SAYFASAYISI
        {
            get { return _SAYFASAYISI; }
            set { _SAYFASAYISI = value; }
        }

        public int KATEGORIID
        {
            get { return _KATEGORIID; }
            set { _KATEGORIID = value; }
        }

        public string KATEGORIADI
        {
            get { return _KategoriAdi; }
            set { _KategoriAdi= value; }
        }

        public DateTime GMT
        {
            get { return _GMT; }
            set { _GMT = value; }
        }

        public string HOSTNAME
        {
            get { return _HOSTNAME; }
            set { _HOSTNAME = value; }
        }



        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
    }
}
