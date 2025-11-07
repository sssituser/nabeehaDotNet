using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandling
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name : ");
            string fname = Console.ReadLine();
            DirectoryInfo info = new DirectoryInfo(fname);
            FileInfo[] infos =  info.GetFiles();
            foreach (FileInfo info2 in infos) {
                Console.WriteLine($"{info2.Name} {info2.CreationTime}");
            }
            
        }
    }
}
