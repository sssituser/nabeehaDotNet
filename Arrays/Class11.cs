using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0]=new int[3] {45,67,78};
            array[1] = new int[4] { 12, 13, 45, 67 };
            array[2] = new int[2] { 66, 77 };
            Console.WriteLine("Jagged Array elements are");
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < array[i].Length; j++) 
                { 
                    if(i==j || i + j == 2)
                    {
                        Console.Write($"{array[i][j]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
