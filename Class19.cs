using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class19
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value ; ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c value : ");
            int c = int.Parse(Console.ReadLine());
            int avg = (a + b + c)/3;
            Console.WriteLine($"a = {a}\tb = {b}\tc = {c}\tAverage : {avg}");


        }
    }
}
