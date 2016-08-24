using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.IO;

namespace DriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.DriveInfo[] allDrives = System.IO.DriveInfo.GetDrives();

            foreach (System.IO.DriveInfo drive in allDrives)
            {
                Console.WriteLine("Drive Name :" + drive.Name);
                Console.WriteLine("Drive Type :"+drive.DriveType);

                if (drive.IsReady)
                {
                    Console.WriteLine("Volumeble:{0,30}",drive.VolumeLabel);
                    Console.WriteLine("Drive Format:{0,30}", drive.DriveFormat);
                    Console.WriteLine("Available FreeSpace:{0,30}", drive.AvailableFreeSpace);
                    Console.WriteLine("Total Freespace:{0,30}", drive.TotalFreeSpace);
                    Console.WriteLine("Total Size:{0,30}", drive.TotalSize);
                }
           
               
                Console.WriteLine("\n************************************\n");
                
            }

            Console.ReadLine();
        }
    }
}
