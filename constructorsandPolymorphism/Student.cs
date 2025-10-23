using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Student
    {
        int StuId;
        string StuName;
        int Marks;

        static Student()  // static consructor.
        {
            Console.WriteLine("static Constructor without parameter");
        }
        public Student()  // Default Constructor
        {
            Console.WriteLine("Hi iam constructor with out parameter");
        }
        public Student(int StuId, string StuName, int Marks)
        { 
            Console.WriteLine("constructor with prameters");
           this.StuId = StuId;
            this.StuName = StuName;
            this.Marks = Marks;
        }
        public  Student(Student student)
        {
            Console.WriteLine("copy Constructor");
            this.StuId =student.StuId;
            this.StuName=student.StuName;
            this.Marks = student.Marks; 
        }

        public void ShowStudent()
        {
            Console.WriteLine($"Student ID :{StuId}\tSTtudent Name : {StuName}\nMarks : {Marks}");
        }
    }
}
