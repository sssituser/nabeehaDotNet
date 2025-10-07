using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class41
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numer : ");
            int num = int.Parse(Console.ReadLine()); // 5
            int copy = num;
            int start = 1;
            int fact = 1;
            do
            {
                fact = fact * num; // 1*5 =>fact = 5*4 => fact = 20*3 => fact = 60*2 => fact = 120

                num--;
            } while (num >= start);  


            Console.WriteLine($"{copy} ! is {fact}");
        }
    }
}
