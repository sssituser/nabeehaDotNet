using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] x = { 78, 56, 34, 23, 90 };
            Console.WriteLine("Array elments are");

            foreach(int var1 in x)
            {
                Console.WriteLine(var1);
            }
            
        }
    }
}
