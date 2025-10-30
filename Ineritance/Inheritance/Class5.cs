using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PA
    {
       protected int a , b ;
        public void ReadValues()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());
        }
        public void ShowValues()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }

    }
    interface IB
    {
        void Sum();
        void Sub();
    }
    interface IC
    {
        void Mul();
        void Div();
    }
    class CD : PA, IB, IC
    {
        public void Div()
        {
            Console.WriteLine($"Quo is :{a / b}");
        }

        public void Mul()
        {
            Console.WriteLine($"Mul is :{a * b}");
        }

        public void Sub()
        {
            Console.WriteLine($"Sub is {a-b}");
        }

        public void Sum()
        {
            Console.WriteLine($"Sum is {a+b}");
        }

        public void Rem()
        {
            Console.WriteLine($"Rem is :{a % b}");
        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            CD p = new CD();
            p.ReadValues();
            p.ShowValues();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
            p.Rem();
        }
    }
}
