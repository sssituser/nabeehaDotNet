using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3] { { 45, 67, 89 }, { 88, 45, 32 } };
            Console.WriteLine("Array elements are");
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }
            for(int row = 0; row < 2; row++) 
            {
                for(int col = 0; col < 3; col++) 
                {
                    Console.Write($"{a[row, col]}\t"); 
                }
                Console.WriteLine();
            }
        }
    }
}
