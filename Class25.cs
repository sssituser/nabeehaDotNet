using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class25
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"a = {a}\tb = {b}");//
            a +=  b;  // a = a+b
            Console.WriteLine($"a = {a}"); // a = 30
            a -= b; // a = a-b
            Console.WriteLine($"a = {a}"); // a = 10

            a *= b;
            Console.WriteLine($"a = {a}"); // a = 200

            a /= b;
            Console.WriteLine($"a = {a}"); // a = 10
            a%=b;// 

            Console.WriteLine($"a ....= {a}"); // 10%20
        }
    }
}
