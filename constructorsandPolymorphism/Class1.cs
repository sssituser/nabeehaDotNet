using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee 1 Object");
            Employee emp1 = new Employee();
            emp1.ShowEmployee();
            Console.WriteLine("Employee 2 Object");
            Employee emp2 = new Employee(201,"Raj",6000);
            emp2.ShowEmployee();
            Console.WriteLine("Employee 3 Object");
            Employee emp3 = new Employee(201, "Ravi", 7000);
            emp3.ShowEmployee();
            Console.WriteLine("Employee 4 Object");
            Employee emp4 = new Employee(emp2);
            emp4.ShowEmployee();

        }
    }
}
