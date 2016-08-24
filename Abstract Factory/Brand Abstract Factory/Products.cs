using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brand_Abstract_Factory
{
    class Bag<Brand>:IBag where Brand:IBrand,new()
    {
        private Brand myBrand;

        public Bag()
        {
            myBrand = new Brand();
        }
        public string material
        {
            get { return myBrand.material; }
        }
    }

    class Shoes<Brand>:IShoes where Brand:IBrand,new()
    {
        private Brand myBrand;

        public Shoes()
        {
            myBrand=new Brand();
        }

        public int price
        {
            get {return myBrand.price; }
        }
    }

}
