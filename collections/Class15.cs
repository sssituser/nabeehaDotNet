using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(11, "Arun");
            dict.Add(10, "Uday");
            dict.Add(13, "venkat");
            dict.Add(12, "raj");
            Console.WriteLine("=======Keys========");
            Console.WriteLine($"Elements present in the dict : {dict.Count}");
            foreach (int key in dict.Keys)
            {
                Console.WriteLine($"{key}    {dict[key]}" );
            }
            Console.WriteLine("=========Values=================");
            foreach (string value in dict.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("===Key Value Pairs=======");

            foreach(KeyValuePair<int,string> keyValue in dict)
            {
                Console.WriteLine(keyValue);
            }



        }
    }
}
