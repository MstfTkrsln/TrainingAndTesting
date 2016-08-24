using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brand_Abstract_Factory
{
    class Client<Brand> where Brand:IBrand,new()
    {
        public void ClientMain()
        {
            IFactory<Brand> factory=new Factory<Brand>();

           IBag bag = factory.CreateBag();
            IShoes shoes = factory.CreateShoes();

            Console.WriteLine("I bougth  a bag which is made from "+bag.material);
            Console.WriteLine("I bougth some shoes which cost "+shoes.price);

        }
    }
}
