using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{
    class Emply
    {
        int EmpId;
        string EmpName;
        int EmpSal;
        public Emply()
        {

        }
        public Emply(int EmpId,string EmpName,int EmpSal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
        public override string ToString()
        {
            return $"EmpId : {EmpId}\nEmpName : {EmpName}\nEmpSal : {EmpSal}";
        }
    }
    internal class Class6
    {
        static void Main(string[] args)
        {
            Emply emply = new Emply(111,"kiran",50000);
            Console.WriteLine(emply);
           
           
        }
    }
}
// Multi level
// Multiple ---Interface(abstraction)
// Hierarchical
// Hybrid Inheritance