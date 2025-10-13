using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 78, 23, 67 };

            Console.WriteLine($"Array elements count :{array.Length}");

            for(int i=0; i<array.Length; i++) // i = 0 i = 1 i = 2 i = 3
            {
                Console.WriteLine(array[i]); // 56 78  23  67
            }

        }
    }
}
