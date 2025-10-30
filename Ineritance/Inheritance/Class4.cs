using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class A
    {
        public void Show()
        {
            Console.WriteLine("Hi Iam Show Method from  class A");
        }
        public void Hi()
        {
            Console.WriteLine("Hi Iam Hi Method from  class A");
        }
    }
    class B : A
    {

        public void Dispaly()
        {
            Console.WriteLine("Hi Iam Display method from Class B");
        }
        public void Bye()
        {
            Console.WriteLine("Hi Im Bye method from class B");
        }

    }
    class C : B
    {

        public void Welcome()
        {
            Console.WriteLine("Hi Im welcome method from class C");
        }
        public void Demo()
        {
            Console.WriteLine("HI Iam Demo method from clss C");
        }

    }
    interface IM
    {
        void Test(); // Undefined Methods
    }

    class D : C, IM
    {
        public void Test()
        {
            Console.WriteLine("Hi Iam Test Method from Interface, Defined In Child D class ");
        }
    }

    internal class Class4
    {

        static void Main(string[] args)
        {
            D p = new D();
            p.Demo();
            p.Welcome();
            p.Show();
            p.Hi();
            p.Dispaly();
            p.Bye();
            p.Test();




        }
    }

}
