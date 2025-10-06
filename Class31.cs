using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class31
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                if (num < 10)
                {
                    Console.WriteLine("Given num is +ve and single digit");
                }
                else
                {
                    Console.WriteLine("Given num is +ve but not single digit");
                }
            }
            else
            {
                Console.WriteLine("num is either 0  Or -ve number");
            }
        }
    }
}
