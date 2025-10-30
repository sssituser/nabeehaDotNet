using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Age : ");
                    int age = int.Parse(Console.ReadLine());
                    if (age <= 0 || age > 120)
                    {
                        throw new InvalidAgeException("....");
                    }
                    Console.WriteLine($"Entered Age is {age}");
                } catch (InvalidAgeException ex) {
                    Console.WriteLine(ex.Message);
                   
                }
            }
        }
    }
}
