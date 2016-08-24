using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Interpress.Library.InterpressFtp
{
   public  class FtpCreator
    {
       public static IInterpressFtp Create()
       {
            if(ConfigurationManager.AppSettings["ftp"]=="edt")
                return new InterpressFtpEdt();
            if (ConfigurationManager.AppSettings["ftp"] == "hamza")
                return new InterpressFtpHamza();
           return null;
       }
    }
}
