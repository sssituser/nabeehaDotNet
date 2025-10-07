using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class37
    {
        static void Main(string[] args)
        {
            int start = 1;
            Console.Write("Enter end value : ");
            int end = int.Parse(Console.ReadLine());



           

            do
            {
                Console.WriteLine($"{start++}");
            } while (start <= end);


        }
    }
}
