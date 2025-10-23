using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Class5
    {
        public static int GetMaxNumber(int[] array) //{123,110,201,654,789,465}
        {
              return    ArrayToNum(SortArrayInDes(GetMaxDigitArray(array)));   //{3,1,2,6,9,6} {9,6,6,3,2,1}

        }

        private static int ArrayToNum(int[] array)  // {6,9,8}
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res = res * 10 + array[i]; //698
            }
            return res;
        }

        private static int[] SortArrayInDes(int[] array) //{8,5,6,9}
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        private static int[] GetMaxDigitArray(int[] array) //{123,110,201,654,789,465}
        {
            int[] res = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
              res[i] =  GetMaxDigit(array[i]);
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[] array = { 123, 110, 201, 654, 789, 465 };

            Console.WriteLine($"Maxinumber of the Array :{GetMaxNumber(array)}");
        }
        private static int GetMaxDigit(int number)
        {
            int maxDigit = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                    maxDigit = digit;
                number /= 10;
            }
            return maxDigit;
        }
    }
}
