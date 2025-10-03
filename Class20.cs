using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dollars : ");
            int dollars = int.Parse(Console.ReadLine());
            int rupees = dollars * 80;
            Console.WriteLine($"{dollars} US Dollars Equals Indian Rupees : {rupees} dollars");
        }
    }
}
