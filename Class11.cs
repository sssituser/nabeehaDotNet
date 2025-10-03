using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Grade: ");
            string grade = Console.ReadLine();
            Console.WriteLine("Enter Percentage: ");
            string percent = Console.ReadLine();

            Console.WriteLine($"name: {name}\n grade: {grade}\n percentage: {percent}");
        }
    }
}
