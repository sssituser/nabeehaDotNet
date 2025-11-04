using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add(3);
            al.Add(4);
            foreach(int k in al)
            {
                Console.WriteLine(k);
            }
            
            al.Sort();
            Console.WriteLine("Array Elements after sorting are");
            foreach (int k in al)
            {
                Console.WriteLine(k);
            }

        }
    }
}
