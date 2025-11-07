using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandling
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Drive Name : ");
            string dname = Console.ReadLine();
             String[] folders =  Directory.GetDirectories(dname);
            Console.WriteLine("Folder Present the above location");
            foreach (String folder in folders) {
                Console.WriteLine($"{folder}");
            }

        }
    }
}
