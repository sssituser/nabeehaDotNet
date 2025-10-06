using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NabeehaConsoleApp
{
    internal class Class35
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
        Menu:
            Console.WriteLine("==================MENU============================");
            Console.Write("1.+\n2.-\n3.*\n4.Div\n5.Rem\nEnter ur choice :");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.WriteLine($"Sum of {num1} and  {num2}  is {num1 + num2}");
                    goto Menu;
                case "-":
                    Console.WriteLine($"Sub of {num1} and  {num2}  is {num1 - num2}");
                    goto Menu;
                case "*":
                    Console.WriteLine($"Mul of {num1} and  {num2}  is {num1 * num2}");
                    goto Menu;
                case "/":
                    Console.WriteLine($"Quo of {num1} and  {num2}  is {num1 / num2}");
                    goto Menu;
                case "%":
                    Console.WriteLine($"Rem of {num1} and  {num2}  is {num1 % num2}");
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice :");
                    break;


            }
        }
    }
}
