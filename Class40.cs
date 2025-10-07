using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class40
    {
        static void Main(string[] args)
        {

            int start = 1;
            int fact = 1;
            Console.Write("Enter a value : ");
            int num =int.Parse(Console.ReadLine());

            while (start <= num) {

                fact = fact * start;
                start ++;
            }
            Console.WriteLine($"{num}! is {fact}");
        }
    }
}
