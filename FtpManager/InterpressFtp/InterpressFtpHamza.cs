using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.InterpressFtp
{
    class InterpressFtpHamza:IInterpressFtp
    {

        public void Connect(string host, string username, string pass)
        {
            Console.WriteLine("Connected");
        }

        public string[] GetFileNames(string directory)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
