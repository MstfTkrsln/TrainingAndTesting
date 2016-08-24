using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspectConsole
{
    public class OrderProcessor:IOrderProcessor
    {


        public bool ProcessOrder(Order newOrder)
        {
            if (newOrder.Discount > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
