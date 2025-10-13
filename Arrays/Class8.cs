using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class8
    {
        static void Main(string[] args)
        {                 
            int[] array = { 56, 54, 76, 23, 98 };
            Console.WriteLine("Array elments are");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for(int i = 0;i < array.Length; i++) 
            {
                for(int j = i+1;j< array.Length; j++) // j= 3,
                {
                     
                    if (array[i] < array[j]) // 56>54
                    {
                        int copy = array[i];// copy = 56
                        array[i] = array[j];// array[i] = 54,23
                        array[j] = copy; //     array[j] = copy array[j] = 56,54
                    }
                }
            }

            Console.WriteLine("After sorting the array elements");
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }





        }
    }
}
