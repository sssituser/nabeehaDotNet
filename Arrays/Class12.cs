using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Console.WriteLine("Enter Array Element");
            for(int i = 0;i<3; i++)
            {
                for(int j=0;j< 3; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Array elements");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
