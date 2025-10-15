using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A matrix elements");
            int[,] a = new int[2, 2];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter B matrix elements");
            int[,] b = new int[2, 2];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("A matrix");

           
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("B matrix");


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n");
            }

            int[,] res = new int[2, 2];
            for(int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 2; j++)
                {
                    for(int k=0;k<2; k++) // i = 0 j=1 k = 0 res[0,0]=5 i = 0 j = 0 k = 2
                    {
                        res[i, j] = a[i, k] * b[k, j] + res[i, j];
                    }
                }
            }
            Console.WriteLine("Marix Multiplication is");
            


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{res[i, j]}\t");
                }
                Console.WriteLine("\n");
            }


        }
    }
}
