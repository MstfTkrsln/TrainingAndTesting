
using System;
using System.Globalization;


namespace DesignPattern
{
    abstract class SoyutArabaFabrikasi
    {
        abstract public SoyutArabaKasasi KasaUret();
        abstract public SoyutArabaLastigi LastikUret();
    }

            class MercedesFabrikasi : SoyutArabaFabrikasi
    {
        public override SoyutArabaKasasi KasaUret()
        {
            return new MercedesE200();
        }

        public override SoyutArabaLastigi LastikUret()
        {
            return new MercedesLastik();
        }
    }

            class FordFabrikasi : SoyutArabaFabrikasi
    {
        public override SoyutArabaKasasi KasaUret()
        {
            return new FordFocus();
        }

        public override SoyutArabaLastigi LastikUret()
        {
            return new FordLastik();
        }
    }

    
            abstract class SoyutArabaKasasi
    {
        abstract public void LastikTak(SoyutArabaLastigi a);
    }

                class MercedesE200 : SoyutArabaKasasi
    {
        public override void LastikTak(SoyutArabaLastigi lastik)
        {
            Console.WriteLine(lastik + " lastikli MercedesE200");
        }
    }
    
                class FordFocus : SoyutArabaKasasi
    {
        public override void LastikTak(SoyutArabaLastigi lastik)
        {
            Console.WriteLine(lastik + " lastikli FordFocus");
        }

    }

    
    
            abstract class SoyutArabaLastigi
    {
    }
    
                 class MercedesLastik : SoyutArabaLastigi
    {
        public MercedesLastik()
        {
            Console.WriteLine(this+" 4 Lastik Yapıldı");
        }
    }

                 class FordLastik : SoyutArabaLastigi
    {
        public FordLastik()
        {
            Console.WriteLine(this + " 4 Lastik Yapıldı");
        }
    }



    class FabrikaOtomasyon
    {
        private SoyutArabaKasasi ArabaKasasi;
        private SoyutArabaLastigi ArabaLastigi;

        public FabrikaOtomasyon(SoyutArabaFabrikasi fabrika)
        {
            ArabaKasasi = fabrika.KasaUret();
            ArabaLastigi = fabrika.LastikUret();
        }

        public void LastikTak()
        {
            ArabaKasasi.LastikTak(ArabaLastigi);
        }
    }

    class UretimBandi
    {
        public static void Main()
        {
            SoyutArabaFabrikasi fabrika1 = new MercedesFabrikasi();
            FabrikaOtomasyon fo1 = new FabrikaOtomasyon(fabrika1);
            fo1.LastikTak();

            SoyutArabaFabrikasi fabrika2 = new FordFabrikasi();
            FabrikaOtomasyon fo2 = new FabrikaOtomasyon(fabrika2);
            fo2.LastikTak();

            Console.ReadLine();
        }
    }
}