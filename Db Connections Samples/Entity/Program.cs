using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {

            TestDbEntities entities=new TestDbEntities();

            var list=entities.Employees.ToList();

            
        }
    }
}
