using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
namespace FileHandling
{
    internal class Class9
    {
        static void Main(string[] args)
        {
               DriveInfo[] drives =     DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Drive Name : {drive.Name}");
                Console.WriteLine($"Drive Type : {drive.DriveType}");
                Console.WriteLine($"Drive Memory : {(drive.TotalSize)/(1024*1024*1024)}GB");
                Console.WriteLine($"Free Space :{drive.AvailableFreeSpace / (1024 * 1024 * 1024)}GB");
            }



            }
           
        }
    }
