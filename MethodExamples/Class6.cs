using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Class6
    {
        // Fix for CS0103: Add the missing method definition
        static int GetNthTermFebonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 0;
            if (n == 2) return 1;
            int a = 0, b = 1, c = 0;
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine($"{num} Term of Febonacci Series : {GetNthTermFebonacci(num)}");
            Console.WriteLine(IsPrime(7));
        }
        // Add the missing IsPrime method to fix CS0103
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
