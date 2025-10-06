using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class24
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a>b ? $"{a} is Max":$"{b} is max");
        }
    }
}
