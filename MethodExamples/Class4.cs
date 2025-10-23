using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Class4
    {
        public static int GetLuckyNumber(string dob) // 19-Oct-2004
        {
          string [] res =  dob.Split('-');
          int date = int.Parse(res[0]);
          int month = ConvertMonthTextToNum(res[1]);
          int year = int.Parse(res[2]);
          int sum =date+month+year;//2033
            while (sum > 9)
            {
                sum = DigitSum(sum);
            }
            return sum;

        }

        private static int DigitSum(int num)
        {
            int sum = 0;
            while (num > 0) //123>0 12>0 1>0 0>0
            {
                sum = sum + num % 10; // sum = 3 sum = 5 sum = 6
                num /=10; // num = 12 num = 1 num = 0
            }
            return sum;
        }

        private static int ConvertMonthTextToNum(string month)
        {
            month = month.ToLower();
            string[] months = { "jan", "feb", "mar", "apr", "may", "jun",
                "jul", "aug", "sep", "oct","nov","dec" };
            for (int i = 0; i < months.Length; i++)
            {
                if (month.Contains(months[i]))
                {
                    return i + 1;
                }
            }
            return 0;

        }

        static void Main(string[] args)
        {
            string dob = "19-Oct-2004";
            Console.WriteLine($"Your Lucky Number is {GetLuckyNumber(dob)}");    
        }
        
    }
}
