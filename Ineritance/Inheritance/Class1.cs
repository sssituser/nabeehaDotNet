using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Dept
    {
     protected   string DeptName;
     protected   int DeptId;
     protected   string DeptLoc;
        public Dept() 
        {
        }
        public Dept(string DeptName, int DeptId, string DeptLoc)
        {
            this.DeptName = DeptName;
            this.DeptId = DeptId;
            this.DeptLoc = DeptLoc;
        }
        public override string ToString()
        {
            return $"DeptId : {DeptId}\tDept Name : {DeptName}\tDeptLocation:{DeptLoc}";
        }

    }
    class Employee : Dept
    {
        int EmpId;
        string EmpName;
        int EmpSal;
        public Employee() { }
        public Employee(int EmpId, string EmpmName, int EmpSal, string DeptName, int DeptId, string DeptLoc) : base(DeptName, DeptId, DeptLoc)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpmName;
            this.EmpSal = EmpSal;

        }

        public override string ToString()
        {
            return $"EmpId:{EmpId}\t{EmpName}\t{EmpSal} {base.ToString()}";
        }
        
    }



    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(345,"kiran",7000,"Admin",456,"Hyd");
            Console.WriteLine(employee);

        }
    }
}
