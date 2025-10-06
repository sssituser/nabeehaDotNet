using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class28
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine()); // 10
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine()); // 10
            if (a > b)
            {
                Console.WriteLine("a is big"); // a is big
            }
            else
            {
                Console.WriteLine("b is big");
            }
        }
    }
}
