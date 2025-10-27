using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{

    class Sample
    {
        public void Show()
        {
            Console.WriteLine("Hi this is Show mehod from class Sample");
        }
        public void Display()
        {
            Console.WriteLine("Hi this Diplay method from class Sample");
        }
    }
    class Tesla : Sample
    {
        public void Hi()
        {
            Console.WriteLine("Hi Iam Hi method from Tesla Class");
        }
        public void Bye()
        {
            Console.WriteLine("Hi Iam bye method from class Tesla");
        }
    }
        internal class Class3
        {
            static void Main(string[] args)
            {

                Tesla t1 = new Tesla();
                t1.Hi();
                t1.Bye();
                t1.Show();
                t1.Display();
            }
        }
    }
