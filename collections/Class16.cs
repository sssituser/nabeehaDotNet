using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            // Write Program to find the character count for given string


            Console.Write("Enter Name : ");
            string name = Console.ReadLine(); // a - 2 r - 2 u-2 n -1 k -1 m-1


            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char ch in name) // abac
            {
                if (dict.ContainsKey(ch))
                {
                    int value = dict[ch];
                    dict.Remove(ch);
                    dict.Add(ch, value+1);
                }
                else
                {
                    dict.Add(ch, 1); // a - 1 b - 1
                }
            }
            Console.WriteLine("Character Count for the given string");
            foreach(KeyValuePair<char,int> keyValuePair in dict)
            {
                Console.WriteLine(keyValuePair);
            }



        }
    }
}
