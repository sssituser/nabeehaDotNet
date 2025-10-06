using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class29
    {
        static void Main(string[] args)
        {
            Console.Write("Enter subject 1 Marks :");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject 2 Marks : ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject 3 Marks : ");
            int s3 = int.Parse(Console.ReadLine());
            if(s1>=35 && s2>=35 && s3 > 35)
            {
                Console.WriteLine("Student Passed");
            }
            else
            {
                Console.WriteLine("Stduent Failed");
            }
        }
    }
}
