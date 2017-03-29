using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Configuration;

namespace GokFramework.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(MethodBase methodBase, string message)
        {
            string logPath = ConfigurationManager.AppSettings["GokFramework.LoggerPath"].TrimEnd('/');
            string logName = DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt";
            string logMessage = string.Format("Namaspace: {0}\r\nClass: {1}\r\nMethod: {2}\r\nMessage: {3}",
methodBase.ReflectedType.Namespace, methodBase.ReflectedType.Name, methodBase.Name, message);
            string path = System.IO.Path.Combine(logPath, logName);

            if (!Directory.Exists((logPath)))
                Directory.CreateDirectory(logPath);

            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(logMessage);
            sw.Close();
            sw.Dispose();
        }
    }
}