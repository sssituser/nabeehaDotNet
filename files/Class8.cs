using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name To Read the Info:");
            string fname = Console.ReadLine();
            StreamReader sr= new StreamReader(fname);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
