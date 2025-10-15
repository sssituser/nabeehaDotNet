using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month : "); //January
            string month = Console.ReadLine(); //
            month = month.ToLower();//january
            int monthNumber = 0;
            string[] months = {"jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec" };
         
            for (int i = 0; i < months.Length; i++)
            {
                if (month.Contains(months[i]))
                {
                    monthNumber = i + 1;
                }
            }
            Console.WriteLine($"{month} Index is :{monthNumber}");

        }
    }
}
