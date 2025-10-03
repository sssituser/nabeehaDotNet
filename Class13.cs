using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a = {a}\tb = {b}");
            Console.WriteLine($"Sum is {a+b}");
        }
    }
}
