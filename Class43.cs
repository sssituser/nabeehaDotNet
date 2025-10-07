using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class43
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // 123
            int rev = 0;
            int copy = num;
           
            while (num > 0)
            {
                int ld = num % 10;
                rev = rev * 10 + ld;
                num = num / 10;
            }
            if(copy == rev)
            {
                Console.WriteLine($"{copy}  is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{copy}  is not a Palindrome");
            }
            
        }
    }
}
