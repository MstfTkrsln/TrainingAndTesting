using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GokFramework.Logger
{
    public class LoggerContext
    {
        #region Properties
        private static ILogger Logger { get; set; }
        #endregion

        public static void Log(MethodBase methodBase, string message)
        {
            Logger.Log(methodBase, message);
        }
    }
}