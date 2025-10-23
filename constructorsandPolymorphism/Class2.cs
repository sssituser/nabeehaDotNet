using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Class2
    {
        static void Main(string[] args)
        {

            Student stud1 = new Student(112, "abc", 300);

            stud1.ShowStudent();

            Student stud2 = new Student(stud1);
            stud2.ShowStudent();
        }

    }
}
