using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnterpriseDT.Net.Ftp;

namespace Interpress.Library.InterpressFtp
{
   public class InterpressFtpEdt:IInterpressFtp
    {
        public void Connect(string host,string username,string pass)
        {
           Console.WriteLine("edt connected");
        }

        public string[] GetFileNames(string directory)
        {
            return null;
        }

        public void CreateDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public byte[] GetFile(string path)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(string path, byte[] data)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
          
        }
    }
}
