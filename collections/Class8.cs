using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("lmn");
            al.Add("pqr");
            al.Add("abc");
            foreach (string k in al)
            {
                Console.WriteLine(k);
            }

            al.Sort();
            Console.WriteLine("Array Elements after sorting are");
            foreach (string k in al)
            {
                Console.WriteLine(k);
            }
        }
    }
}
