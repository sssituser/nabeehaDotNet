using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Int value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter double value : ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter float value : ");
            float f = float.Parse(Console.ReadLine());
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();


            Console.WriteLine("Displaying the values ");
            Console.WriteLine($"a = {a}\td = {d}\tf = {f}\ts = {s}");
        }
    }
}
