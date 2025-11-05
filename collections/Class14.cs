using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            SortedSet<studentt> stuSet = new SortedSet<studentt>();
            stuSet.Add(new studentt(11, "arun"));
            stuSet.Add(new studentt(10, "raj"));
            stuSet.Add(new studentt(12, "kiranraj"));
            stuSet.Add(new studentt(14, "venkat"));
            stuSet.Add(new studentt(13, "Shanmukh"));
            stuSet.Add(new studentt(15, "Prasanna"));
            stuSet.Add(new studentt(16, "Nabeeha"));
            Console.WriteLine("Displaying the students");
            foreach (studentt stu in stuSet)
            {
                Console.WriteLine(stu);
            }

        }
    }
}
