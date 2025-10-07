using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class38
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value:");

            int start = int.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine($"{start--}");
            }
            while (start >= 1);


            }
    }
}
