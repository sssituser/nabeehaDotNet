using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class23
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a boolean value : ");
            bool b = bool.Parse(Console.ReadLine()); // false
            //string res = b ? "Hi" : "bye";
            //Console.WriteLine(res);
            Console.WriteLine(b?"Hi":"bye");
        }
    }
}
