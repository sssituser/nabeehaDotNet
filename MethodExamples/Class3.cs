using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Class3
    {

        //  num = 12   square = 144
       // revnum= 21 revsquare = 441   rev revsqare = 144

        public static bool IsAdam(int num)
        {
          return  Square(num) == Reverse(Square(Reverse(num)));
        }

        public static int Square(int num)
        {
            return num * num;
        }
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;

            }
            return rev;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(IsAdam(12));

        }
    }
}
