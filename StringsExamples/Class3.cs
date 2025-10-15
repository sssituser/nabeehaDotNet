using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            string s = "welcome";
            Console.WriteLine(s[0]);

            Console.WriteLine(s.ElementAt(2));
            Console.WriteLine(s.Substring(0,2));
            Console.WriteLine(s.Substring(1,3));
        }
    }
}
