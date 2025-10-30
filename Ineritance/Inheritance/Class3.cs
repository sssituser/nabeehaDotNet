using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Sample
    {
        protected int a, b; //variables
        public void GetValues()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());

        }  //non abstract methodds
        public void ShowVaules()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }    // non abstact method

        public abstract void Sum();
        public abstract void Sub();
      
    }

    class Simple : Sample
    {
        public override void Sub()
        {
            Console.WriteLine($"Sub is :{a-b}");
        }

        public override void Sum()
        {
            Console.WriteLine($"Sum is : {a+b}");
        }
        public void Avg()
        {
            Console.WriteLine($"Avg is {(a+b)/2}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul is {a*b}");
        }
    }

    internal class Class3
    {
        static void Main(string[] args)
        {
            Simple s = new Simple();
            s.GetValues();
            s.ShowVaules();
            s.Sum();
            s.Sub();
            s.Avg();
            s.Mul();
        }
    }
}
