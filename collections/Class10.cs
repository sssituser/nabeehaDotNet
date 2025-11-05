using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("arun");
            nameList.Add("raj");
            nameList.Add("nabeeha");
            nameList.Add("venkat");
            foreach (string s in nameList)
            {
                Console.WriteLine(s);
            }
            nameList.Remove("arun");

            Console.WriteLine("After removing the name nameList");

            foreach (string s in nameList)
            {
                Console.WriteLine(s);
            }











        }
    }
}
