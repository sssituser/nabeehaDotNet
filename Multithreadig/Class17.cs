using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    class Demo
    {
        public void Test()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} . Welcome to DotNet Training");
            }
        }
        public void Hi()
        {
            for(int i = 1;i <= 10; i++)
            {
                Console.WriteLine($"{i} Hi this is hi mehod from class Demo");
            }
        }
        internal class Class17
        {
            static void Main(string[] args)
            {
                Demo p = new Demo();
                p.Test();
                p.Hi();

            }
        }
    }
}
