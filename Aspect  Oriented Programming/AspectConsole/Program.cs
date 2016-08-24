using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AspectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Initialize();

            IOrderProcessor processor = Bootstrapper.Container.Resolve<IOrderProcessor>();

            Order order=new Order();
            order.ProductId = 1;
            order.Price = 12;
            order.Discount=11;
            order.Quantity = 4;
            order.OrderDate = DateTime.Now;

            bool isSuccess = processor.ProcessOrder(order);

            if(isSuccess)
            Console.WriteLine("Order Success");
            else
                Console.WriteLine("Order isn't Success ");
            Console.ReadKey();

        }
    }
}
