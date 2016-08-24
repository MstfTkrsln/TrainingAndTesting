using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brand_Abstract_Factory
{
    class Gucci:IBrand
    {
        public int price
        {
            get { return 1000; }
        }

        public string material
        {
            get { return "Crocodile Skin"; }
        }
    }

    class Poochy:IBrand
    {

        public int price
        {
            get { return new Gucci().price/3; }
        }

        public string material
        {
            get { return "Plastic"; }
        }
    }

    class Groundcover:IBrand
    {

        public int price
        {
            get { return 2000; }
        }

        public string material
        {
            get { return "Leather"; }
        }
    }
}
