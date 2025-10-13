using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // int[] array = new int[4] { 56, 78, 23, 67 };
            int[] array = { 56, 78, 23, 67 };
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);

            Console.WriteLine($"{array[0]}    {array[1]}     {array[2]}    {array[3]}");
        }
    }
}
