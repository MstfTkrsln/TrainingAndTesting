using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspectConsole
{
   public interface IOrderProcessor
   {
       bool ProcessOrder(Order newOrder);
   }
}
