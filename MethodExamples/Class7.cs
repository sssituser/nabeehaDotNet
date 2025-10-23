using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectNumber(28));
        }

        // Fix for CS0103: Add the missing IsPerfectNumber method
        static bool IsPerfectNumber(int number)
        {
            if (number < 2) return false;
            int sum = 1;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }
    }
}
