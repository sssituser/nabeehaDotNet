using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string str = "kiran";
            Console.WriteLine(str); //kiran
            string s = str.ToUpper(); // new memory
            Console.WriteLine(s); //KIRAN
            Console.WriteLine(str);//kiran
        }
    }
}
