using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class39
    {
        static void Main(string[] args)
        {
            int start = 1;
            Console.Write("Enter a number :");
            int num = int.Parse(Console.ReadLine()); // num = 5
            int sum = 0;

            do
            { // 1<=5 2<=5 3<=5 4<=5 5<=5 6<=5
                sum = sum + start; // sum = 1 sum = 3 sum = 6 sum = 10 sum = 15
                start++;
            } while (start <= num);

            Console.WriteLine($"sum of {num} numbers is {sum}");
        }
    }
}
