﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpress.Library.InterpressFtp;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            IInterpressFtp ftp = FtpCreator.Create();
             ftp.Connect("","","");
        }
    }
}
