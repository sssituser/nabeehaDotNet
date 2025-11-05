using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>();
            set.Add(8);
            set.Add(5);
            set.Add(6);
            set.Add(4);
            set.Add(7);
            set.Add(3);
            set.Add(1);
            set.Add(2);
            set.Add(3);
            Console.WriteLine("Sorted Set Elements are");
            foreach(int num in set)
            {
                Console.WriteLine(num); 
            }

        }
    }
}
