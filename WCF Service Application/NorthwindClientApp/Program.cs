using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindClientApp.ProductServiceConsumer;

namespace NorthwindClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindProductServiceClient proxy = new NorthwindProductServiceClient("WSHttpBinding_NorthwindProductService");


            var productList = proxy.GetProducts(2);

            foreach (SurrogateProduct product in productList)
            {
                Console.WriteLine("{0} {1} {2}",product.CategoryId,product.ProductId,product.ProductName);
            }

            Console.ReadLine();

        }
    }
}
