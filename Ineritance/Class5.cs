using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Hi Iam show method from Parent class");
        }
        public void Display()
        {
            Console.WriteLine("Hi Iam display method from Child class");
        }
    }

    class Child : Parent
    {
        public void Hi()
        {
            Console.WriteLine("Hi Im Hi method from Child class");
        }
        public void Bye()
        {
            Console.WriteLine("Hi Iam Bye method from child class");
        }
    }


    internal class Class5
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Hi();
            c.Bye();
            c.Show();
            c.Display();
        }
    }
}
