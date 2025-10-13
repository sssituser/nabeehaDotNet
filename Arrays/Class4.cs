using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[] x = { 78, 56, 34, 23, 90 };

            Console.WriteLine($"Sum of the array elements is :{x.Sum()}");
            Console.WriteLine($"Max element in the array is :{x.Max()}");
            Console.WriteLine($"Min element in the array is :{x.Min()}");
            Console.WriteLine($"Average of the array elemens is :{x.Average()}");
        }
    }
}
