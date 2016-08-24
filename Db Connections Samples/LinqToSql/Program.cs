using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {

            LinqToSqlModelDataContext cnt=new LinqToSqlModelDataContext();

            var list = cnt.Employees;



        }
    }
}
