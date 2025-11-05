using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            List<int> numsList=new List<int>();
            numsList.Add(10);
            numsList.Add(20);
            numsList.Add(50);
            numsList.Add(40);
            numsList.Add(60);
            numsList.Add(10);

            foreach (int num in numsList)
            {
                Console.WriteLine(num);
            }
            numsList.Remove(10);
            numsList.Sort();
            numsList.Reverse();
            Console.WriteLine("Elements in the List in Reverse order");
            foreach (int num in numsList)
            {
                Console.WriteLine(num);
            }

        }
    }
}
