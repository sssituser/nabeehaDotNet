using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Program
    {
        public static int Sum(int num1,int num2)   // Method definition
        {
          return  num1 + num2;
        }
        static void Main(string[] args)
        {
           int res = Sum(4, 5/*Actual Parameters*/); // consuming the method(Calling method)
           
            
            Console.WriteLine($"Result of Sum method is :{res} ");

            Console.WriteLine($"Result of Sum method is {Sum(5,7)}");

        }
    }
}
