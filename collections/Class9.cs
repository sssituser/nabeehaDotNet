using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6pmto7pm
{
    class studentt : IComparable
    {
        public int id;
        public string name;
        public studentt() { 
        
        }
        public studentt(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            studentt tempobj = obj as studentt;
            if (this.id > tempobj.id)
            {
                return -1;
            }
            if (this.id < tempobj.id)
            {
                return 1;
            }
            return 0;
        }
        //public int CompareTo(Object obj)
        //{   studentt stuobj=obj as studentt;


        //    return this.name.CompareTo(stuobj.name);
        //}

        public override string ToString()
        {
            return id + "\t" + name;
        }
    }
    internal class Class9
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new studentt(4,"abc"));
            al.Add(new studentt(3,"kiran"));
            al.Add(new studentt(5, "raj"));
           
            foreach (studentt k in al)
            {
                Console.WriteLine(k);
            }

            al.Sort();
            Console.WriteLine("Array Elements after sorting are");
            foreach (studentt k in al)
            {
                Console.WriteLine(k);
            }
        }
    }
}
// How to sort the ArrayList for custom objects