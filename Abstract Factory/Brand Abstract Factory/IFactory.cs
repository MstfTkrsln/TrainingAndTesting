using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brand_Abstract_Factory
{
    interface IFactory<Brand> where Brand : IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();

    }
}
