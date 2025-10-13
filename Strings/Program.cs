using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "welcome to online Training";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Contains("online"));
            Console.WriteLine(str.Contains("arun"));
            Console.WriteLine(str.Equals("abc"));
        }
    }
}
