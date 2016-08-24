using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using FacadeLayer;

namespace BusinessLayer
{
    public class BLKategori
    {
        public static int Insert(Kategori kategori)
        {
            if (kategori.ADI!=null && kategori.ADI.Trim().Length>0)
            {
                return Kategoriler.Insert(kategori);
            }

            return -1;
        }

        public static bool Update(Kategori kategori)
        {

            if (kategori.ADI != null && kategori.ADI.Trim().Length > 0 && kategori.ID>0)
            {
                return Kategoriler.Update(kategori);
            }

            return false;

        }

        public static bool Delete(int id)
        {
            if (id > 0)
            {
                return Kategoriler.Delete(id);
            }

            return false;

        }

        public static Kategori Select(int id)
        {

            if (id > 0)
            {
                return Kategoriler.Select(id);
            }

            return null;
        }

        public static List<Kategori> SelectList()
        {
            
            return Kategoriler.SelectList();

        }
    }
}
