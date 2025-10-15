using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    // Write a program to find out the square of  given number
    internal class Class1
    {
        public static int Square(int x)
        {
           return x*x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            int res = Square(10);

            Console.WriteLine($"Result of a method {res}");


            Console.WriteLine(Square(12));

        }
    }
}
