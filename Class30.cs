using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class30
    {
        static void Main(string[] args)
        {
            Console.Write("Enter user Name :");
            string uname = Console.ReadLine();
            Console.Write("Enter Password : ");
            string pwd = Console.ReadLine();
            if (uname == "admin" && pwd == "admin")
            {
                Console.WriteLine("Welcome User...");
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password");
            }
        }
    }
}
