using System;
using NHibernate;
using NHibernate.Cfg;

namespace NorthwindClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var configuration = new Configuration();
            configuration.Configure();

            using (var mySessionFactory = configuration.BuildSessionFactory())
            {
                using (var mySession = mySessionFactory.OpenSession())
                {

                    //IList productList = mySession.CreateCriteria(typeof(Products)).List();

                    //foreach (Products product in productList)
                    //{
                    //    Console.WriteLine(product.ProductName);
                    //}

                    //Console.ReadLine();


                    using (ITransaction tran = mySession.BeginTransaction())
                    {
                        var product1 = new Products
                        {
                            ProductName = "Apple",
                            Discontinued = true,
                            CategoryID = 4,
                            ReorderLevel = 5,
                            SupplierID = 4,
                            UnitPrice = 1250,
                            UnitsInStock = 100,
                            UnitsOnOrder = 5

                        };

                       var a= mySession.Save(product1);

                        tran.Commit();

                    }
                }

            }


            Console.WriteLine("Kayıt Eklendi...");
            Console.ReadLine();

        }
    }
}
