using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Contact number: ");
            string contact = Console.ReadLine();

            Console.WriteLine($"name: {name}\n age: {age}\n contact number: {contact}");
       }
    }
}
