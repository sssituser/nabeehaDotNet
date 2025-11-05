using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            List<studentt> stuList = new List<studentt>();
            stuList.Add(new studentt(11,"arun"));
            stuList.Add(new studentt(10,"raj"));
            stuList.Add(new studentt(12,"kiranraj"));
            stuList.Add(new studentt(14,"venkat"));
            stuList.Add(new studentt(13,"Shanmukh"));
            stuList.Add(new studentt(15,"Prasanna"));
            stuList.Add(new studentt(16,"Nabeeha"));

            
            foreach (studentt stu in stuList)
            {
                Console.WriteLine(stu);
            }

            Console.WriteLine("=====Student in Sorted Order=======");
            stuList.Sort();
            foreach (studentt stu in stuList)
            {
                Console.WriteLine(stu);
            }
        }

    }
}
