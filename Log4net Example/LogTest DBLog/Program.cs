using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;
using log4net.Appender;

namespace LogTest_DBLog
{
    class Program
    {

        static ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        static void Main(string[] args)
        {
            
            
            log.Error("Hata Oluştu...");

            log.Info("Info eklemdi");

            log.Debug("Debug eklendi");
            
           
            Console.ReadKey();

        }
    }
}
