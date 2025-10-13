using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace NabeehaConsoleApp
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            string[] names = new string[5]; // names[0] = kiran
            int[] s1 = new int[5]; // s1[0] = 40
            int[] s2 = new int[5]; // s2[0] = 50
            int[] s3 = new int[5]; // s3[0] = 60
            int[] tot = new int[5]; // tot[0] = 150
            string[] res = new string[5];//res[0]="Passed"

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name : ");
                names[i] = Console.ReadLine();
                Console.Write("Enter subject 1 marks : ");
                s1[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter subject 2 marks : ");
                s2[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter subject 3 marks : ");
                s3[i] = int.Parse(Console.ReadLine());
                tot[i] = s1[i] + s2[i] + s3[i];
                if (s1[i] >= 35 && s2[i] >= 35 && s3[i] >= 35)
                {
                    res[i] = "Passed";
                } else {
                    res[i] = "Failed";
                }

            }
            Console.WriteLine("Names\tMarks1\tMark2\tMarks3\tTotal\tResult");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t{s1[i]}\t{s2[i]}\t{s3[i]}\t{tot[i]}\t{res[i]}");
            }






        }
    }
}
