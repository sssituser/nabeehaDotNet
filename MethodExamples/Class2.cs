using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    // Write a program find the factorial of given number using mehods.
    internal class Class2
    {
        public static int Factorial(int num) //
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }


        //Write a program to read a name and decrypt it using methods.

        public static string Decrpyt(string name)
        {
            string alpa = "abcdefghijklmnopqrstuvwxyz";
            string ralp = "zyxwvutsrqponmlkjihgfedcba";
            string res = string.Empty;
            foreach(char ch in name)
            {
                res += ralp.ElementAt(alpa.IndexOf(ch));
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial of 5 is {Factorial(5)}");
            int res = Factorial(4);
            Console.WriteLine($"Factorial 4 is {res}");

            Console.WriteLine(Decrpyt("abc"));
            Console.WriteLine(Decrpyt("arun"));
        }
    }
}
