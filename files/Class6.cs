using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandling
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Inforamation:");
            string info = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine(info);
            sw.Close();


        }
    }
}
