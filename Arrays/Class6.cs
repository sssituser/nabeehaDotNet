using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int[] x = { 78, 56, 34, 23, 90 };
            Console.WriteLine("Array elements in Asending");
            Array.Sort(x);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(x);
            Console.WriteLine("Array elements in Desending order");
            Array.Sort(x);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }


        }
    }
}
