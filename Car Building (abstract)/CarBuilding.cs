using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    public abstract class AbsractBuilderAraba
    {
        
        abstract public int doorCount { get; }

        private void CreateKapı()
        {
            Console.WriteLine("Kapılar Yapıldı.");
        }

        private void CreateTekerlek()
        {
            Console.WriteLine("Tekerlekler Yapıldı");
        }

        private void CamlariTak()
        {
            Console.WriteLine("Camlar Takıldı");
        }

        public void Create()
        {
            CreateKapı();
            CreateTekerlek();
            CamlariTak();
        }
    }

    public class BmwBuilder : AbsractBuilderAraba
    {
        public BmwBuilder()
        {
           
            Console.WriteLine(doorCount+" Kapılı BMW Yapılıyor....");
            Console.WriteLine("******************");

        }
        
        public override int doorCount
        {
            get { return 4; }
           
        }
    }
}

