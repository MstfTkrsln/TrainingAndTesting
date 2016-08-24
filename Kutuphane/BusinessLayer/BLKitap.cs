using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using FacadeLayer;

namespace BusinessLayer
{
    public class BLKitap
    {
        public static int Insert(Kitap kitap)
        {
            if (kitap.ADI != null && kitap.ADI.Trim().Length > 0 &&  kitap.KATEGORIID > 0 && kitap.SAYFASAYISI > 0)
            {
                return Kitaplar.Insert(kitap);
            }

            return -1;

        }

        public static bool Update(Kitap kitap)
        {
            if (kitap.ADI != null && kitap.ADI.Trim().Length > 0 && kitap.ID > 0 && kitap.KATEGORIID > 0 && kitap.SAYFASAYISI > 0)
            {
                return Kitaplar.Update(kitap);
            }

            return false;

        }

        public static bool Delete(int id)
        {
            if (id > 0)
            {
                return Kitaplar.Delete(id);
            }
            return false;

        }

        public static Kitap Select(int id)
        {
            if (id > 0)
            {
                return Kitaplar.Select(id);
            }
            return null;

        }

        public static List<Kitap> SelectList()
        {

            return Kitaplar.SelectList();

        }
    }
}
