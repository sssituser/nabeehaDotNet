using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class42
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // 123
            int rev = 0;
            while (num > 0) { //123>0 12>0 1>0 0>0
                int ld = num % 10; // ld = 3 ld = 2 ld = 1
                rev = rev *10 + ld; // rev = 3 rev = 32 rev = 321
                num = num / 10;// num = 12 num = 1 num = 0
            }
            Console.WriteLine($"Reverse number is : {rev}");
        }
    }
}
