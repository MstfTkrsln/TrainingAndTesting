using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.InterpressFtp
{
    public interface IInterpressFtp
    {
        void Connect(string host,string username,string pass);
        string[] GetFileNames(string directory);
        void CreateDirectory(string path);
        void DeleteDirectory(string path);
        byte[] GetFile(string path);
        void UploadFile(string path, byte[] data);
        void Close();
        
    }

    
}
