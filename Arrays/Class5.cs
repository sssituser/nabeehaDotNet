using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int[] x = { 78, 56, 34, 23, 90 };
            Console.WriteLine("Array elements are");
            foreach(int i in x)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Array elements in reverse ");
            Array.Reverse(x);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }






            Array.Sort(x);
            Console.WriteLine("Array elements after sorting");
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }



        }
    }
}
