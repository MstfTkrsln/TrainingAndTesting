using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using log4net;
using log4net.Core;

namespace LogTest
{
    class Program
    {
        static ILog log = log4net.LogManager.GetLogger(typeof(Program));

        

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            

           

            //SqlConnection connection = null;

            //try
            //{
            //    const string connectionString = @"data source=(local);Initial Catalog=Basin;Integrated Security=True;";

            //    log.Warn(string.Format("Bağlantı Açılacak. Connection String :{0}", connectionString));

            //    connection = new SqlConnection(connectionString);

            //    if (connection.State == ConnectionState.Closed)
            //        connection.Open();

            //    log.Info(string.Format("Bağlantı durumu : {0}", connection.State));


        
            //   string query = "INSERT INTO Gazete(ID,Name,Sales) VALUES('10','NewYork Times','1000')";

            //    SqlCommand command=new SqlCommand("INSERT INTO Gazete(Name,Sales) VALUES('Washington','1000')",connection);

            //    command.ExecuteNonQuery();

               
                
            //    log.Info("Veritabanına veriler eklendi.");

            //}
            //catch (Exception ex)
            //{
            //    log.Error(ex.Message);
            //}
            //finally
            //{
            //    if (connection != null && connection.State == ConnectionState.Open)
            //    {
            //        connection.Close();
            //        log.Debug(String.Format("Finally bloğundayız. Bağlantı durumu {0}", connection.State));
            //    }

            //}

            //log.Info("Program Sonu");

           

            Console.ReadKey();
        }
    }
}
