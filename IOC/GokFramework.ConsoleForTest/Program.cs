using GokFramework.IoCContainer;
using GokFramework.Logger;
using System.Reflection;

namespace GokFramework.ConsoleForTest
{
    class Program
    {
        static void Main(string[] args)
        {          
            #region Logger Test
            // Application_Start'da bir kere çalıştırılacak, injection için.
            IoCResolver.getInstance.Resolve<LoggerContext, FileLogger>();

            // Tüm projede injection yapılan tipte çalışacaktır.
            LoggerContext.Log(MethodBase.GetCurrentMethod(), "blabla");
            #endregion
        }
    }
}
