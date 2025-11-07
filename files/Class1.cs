using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandling
{
    internal class Class1
    {
        // static method can be calle using class Name
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name : ");
            string fname = Console.ReadLine();
         // Directory.CreateDirectory(fname);
           Directory.Delete(fname);
            


        }
    }
}
