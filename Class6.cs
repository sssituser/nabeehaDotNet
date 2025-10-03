using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int i = 10000;
            float f = 4.5f;
            double d = 5.6;
            string str = "welcome";
            bool b = true; // Initilize 
            Console.WriteLine(i); // Display
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(str);
            Console.WriteLine(b);

            Console.WriteLine($"{i}\t{f}\t{d}\t{str}\t{b}");
            Console.WriteLine($"i = {i}\tf = {f}\td = {d}\tstr = {str}\tb = {b}");
            Console.WriteLine("=================================================");

            Console.WriteLine("f = {0}\t d = {1}\tstr = {2}\t i = {3}\tb = {4}",f,d,str,i,b);
            Console.WriteLine("========================================================");
            Console.WriteLine(i+"  "+f+"   "+d+"  "+str+"   "+b);








        }
    }
}
