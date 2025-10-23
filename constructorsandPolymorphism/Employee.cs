using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSal;
        public Employee()  //Default Constructor or Constructor without parameter
        {
            EmpId = 111;
            EmpName =  "abc";
            EmpSal = 50000;
            Console.WriteLine("Hi Iam Constructor without paramters");
        }
        public Employee(int EmpId,string EmpName,int EmpSal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
            Console.WriteLine("HI Iam constructor with paramter");
        }

        public Employee(Employee emp) // emp2{201,Raj,60000)
        {
            Console.WriteLine("Hi Iam Copy Constructor....");
            this.EmpId = emp.EmpId;
            this.EmpName = emp.EmpName;
            this.EmpSal = emp.EmpSal;
        }

        static Employee()
        {
            Console.WriteLine("Hi iam static constructor");
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"EmpId : {EmpId}\nEmployee Name : {EmpName}\nEmployee Salary : {EmpSal}");
        }

    }
}
