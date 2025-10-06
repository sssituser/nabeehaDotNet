using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class26
    {
        static void Main(string[] args)
        {
            Console.Write("Enter s1 Marks : ");
            int s1 = int.Parse(Console.ReadLine()); // 40
            Console.Write("Enter s2 Marks : ");
            int s2 = int.Parse(Console.ReadLine()); // 50
            Console.Write("Enter s3 Marks : ");
            int s3 = int.Parse(Console.ReadLine()); // 30

            Console.WriteLine(s1>35 && s2>35 && s3>35 ? " Passed  ":" Failed ");

        }
    }
}
