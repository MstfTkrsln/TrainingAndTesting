using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace FileStream
{
    class Stream:IDisposable
    {
        
System.IO.FileStream fs = new System.IO.FileStream("data.txt", FileMode.Create, FileAccess.ReadWrite,
        FileShare.None);
    

       
        public void Write(char[] data)
            {

                try
                {
                Console.WriteLine("CanWrite : {0}\nCanRead : {1}\nCanSeek : {2}",    fs.CanWrite, fs.CanRead, fs.CanSeek);
                

                if (fs.CanWrite)
                {
                    
                    byte[] dataBytes=Encoding.UTF8.GetBytes((data));
                   
                    fs.Write(dataBytes,0,dataBytes.Length);
                    
                    
                    //fs.Write(data,0,data.Length);
                    //foreach (byte b in data)
                    //{
                    //    fs.WriteByte(b);
                    //}
                    Console.WriteLine("Bilgiler Yazıldı...");
                }

                Console.WriteLine("Position : " + fs.Position);
               

            }
            catch(Exception ex)
                {

                    Console.WriteLine("Exception !!! "+ ex);
                }
            }

        public void Read()
        {
            byte[] buffer=new byte[fs.Length];
            try
                {
                Console.WriteLine("CanWrite : {0}\nCanRead : {1}\nCanSeek : {2}",    fs.CanWrite, fs.CanRead, fs.CanSeek);


                    if (fs.CanRead)
                    {
                        //fs.Read(buffer, 0, buffer.Length);
                        //foreach (byte b in buffer)
                        //{

                        //    Console.WriteLine(b);

                        //}
                        //*********************************
                        
                           fs.Seek(0, SeekOrigin.Begin);
                       
                           
                        //    while (fs.Position<fs.Length)
                        //    {
                        //        Console.WriteLine(fs.ReadByte());
                        //    }
                        //    Console.WriteLine("Bilgiler Okundu...");
                        Console.WriteLine("**************************");
                        
                        fs.Read(buffer, 0, buffer.Length);
                        
                        string s=Encoding.UTF8.GetString(buffer);
                        Console.WriteLine("Stringe Unicode Edilen Metin :  "+s);
                        Console.WriteLine();
                        
                        
                        Console.WriteLine("*********Bytes***********");

                        
                        foreach (var b in buffer)
                        {
                            Console.WriteLine(b);
                        }
                        Console.WriteLine("Position : " + fs.Position);

                    }
                }
            catch(Exception ex)
                {

                    Console.WriteLine("Exception !!! "+ ex);
                }
        }

        
        
        ~Stream()
        {
            Dispose();
            
        }

        public void Dispose()
        {
            
            fs.Close();
            fs.Dispose();
        }
    }
}
