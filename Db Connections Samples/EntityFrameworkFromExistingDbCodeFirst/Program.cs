using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFromExistingDbCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            Model1 model=new Model1();
            
            var list=model.Employees.ToList();
        }
    }
}
