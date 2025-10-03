using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a = {a}\tb = {b}");
            Console.WriteLine($"Sum : {a+b}\tSub:{a-b}\tMul = {a*b}\tDiv {a/b}\t Mode {a%b}");


        }
    }
}
