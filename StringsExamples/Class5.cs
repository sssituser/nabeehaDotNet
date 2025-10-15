using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name :"); //abc
            string name = Console.ReadLine();
            name=name.ToLower();
            int sum = 0;
            string alphas = "abcdefghijklmnopqrstuvwxyz";
            foreach(char ch in name) // abc
            {

                sum += alphas.IndexOf(ch) + 1;
                
            }
            Console.WriteLine($"Abou Name Score :{sum}");
        }
    }
}
