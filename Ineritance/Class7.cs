using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{
    class AA
    {
        protected int a ,b ;
        public void ReaValues()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b  value : ");
            b = int.Parse(Console.ReadLine());
        }
        
    }
    class BB : AA
    {
        public void ShowValues()
        {
            Console.WriteLine($"a = {a}\t b = {b}");
        }
    }
    class CC : BB  
    {
        public void Sum()
        {
            Console.WriteLine($"Sum is :{a+b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub is : {a-b}");
        }
    }
    interface Ix
    {
        void Mul();
        void Rem();
    }
    class DD : CC, Ix  // Multiple Inheritance
    {
        public void Div()
        {
            Console.WriteLine($"Quo is :{a/b}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul of a and b is :{a*b}");
        }

        public void Rem()
        {
            Console.WriteLine($"Rem is {a%b}");
        }
    }
    internal class Class7
    {
        static void Main(string[] args)
        {
            
            DD p = new DD();
            p.ReaValues();
            p.ShowValues();
            p.Sub();
            p.Sum();
            p.Mul();
            p.Div();
            p.Rem();
        }
    }
}
