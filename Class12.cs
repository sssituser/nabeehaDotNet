using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            string a = Console.ReadLine();
            Console.Write("Enter b value : ");
            string b = Console.ReadLine();
            Console.WriteLine($"a = {a}\t b = {b}");
            Console.WriteLine($"sum is :{a+b}");
        }
    }
}
