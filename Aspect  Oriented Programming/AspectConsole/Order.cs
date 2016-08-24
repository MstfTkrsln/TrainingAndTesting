using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AspectConsole
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Discount { get; set; }
        public decimal Price { get; set; }
        public int  Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
