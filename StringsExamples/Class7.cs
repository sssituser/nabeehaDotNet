using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();//abc
            string alph = "abcdefghijklmnopqrstuvwxyz";
            string ralp = "zyxwvutsrqponmlkjihgfedcba";
            string res = string.Empty;
            foreach(char ch in name) //abc
            {
             res +=  ralp.ElementAt(alph.IndexOf(ch));
            }
            Console.WriteLine($"{name} Decrypted String is :{res}");


        }
    }
}
