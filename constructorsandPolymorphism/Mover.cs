using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Mover
    {
        public void Area(int s)
        {
            Console.WriteLine($"Area of square is {s*s}");
        }
        public void Area(int l,int b)
        {
            Console.WriteLine($"Area of Reactangle is {l * b}");
        }
        public void Area(double r)
        {
            Console.WriteLine($"Area of a circle is :{3.14*r*r}");
        }
    }
}
