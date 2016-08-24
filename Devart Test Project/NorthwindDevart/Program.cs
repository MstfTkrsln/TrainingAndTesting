using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate.Cfg.ConfigurationSchema;

namespace NorthwindDevart
{
    class Program
    {
        static void Main(string[] args)
        {
           Configuration config=new Configuration();

            config.Configure();

            var mySessionFactory = config.BuildSessionFactory();


            var mySession= mySessionFactory.OpenSession();

            IList productList = mySession.CreateCriteria(typeof(Product)).List();

            foreach (Product product in productList)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();

        }
    }
}
