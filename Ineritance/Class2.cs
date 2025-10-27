using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{
    class SciCaly : Calcy
    {
        public void Cos(int val)
        {
            Console.WriteLine(Math.Cos(val));
        }
        public void Sin(int val)
        {
            Console.WriteLine(Math.Sin(val));
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            SciCaly sci = new SciCaly();
            sci.Cos(0);
            sci.Sin(90);
            sci.Sum(5, 6);
            sci.Sub(5, 2);
            

        }
    }
}
