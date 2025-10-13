using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int[,] array = { {12,45,67 },{66,78,90 },{56,33,24 } };

            Console.WriteLine("Array elements");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == j || i + j == 2)
                    {
                        Console.Write($"{array[i,j]}\t");
                    }
                    else
                    {
                       Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine("Array elements");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j || i + j == 2)
                    {
                        
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
