using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandling
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name :");
            string fname = Console.ReadLine();
            DirectoryInfo info = new DirectoryInfo(fname);
            Console.WriteLine($"Folder Created Time : {info.CreationTime}");
        }
    }
}
