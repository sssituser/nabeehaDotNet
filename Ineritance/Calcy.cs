using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{
    internal class Calcy
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine($"Sum is {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Sub is {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"Mul is {a * b}");
        }
    }
}
