using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class6  
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee(123, "abcc", 50000, 111, "HR", "hyd", 10, 20));
            al.Add(new Employee(124, "def", 80000, 112, "Admin", "hyd", 50, 20));
            al.Add(new Employee(120, "lmn", 80000, 113, "Admin", "hyd", 50, 20));
            al.Sort();
            foreach (Employee emp in al)
            {
                Console.WriteLine(emp.ToString());
            }
        }

       
    }
}
