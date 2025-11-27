using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
namespace ConsoleAppWithAdo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic bl;
            while (true)
            {
                Console.Write("1.Insert\n2.Delete\n3.Updtae\n4.Find\n5.FindAll\nEnter ur choice :");
                int choice = int.Parse(Console.ReadLine());
                Employee emp = new Employee();
                switch(choice){
                    case 1:
                        try
                        {
                            Console.Write("Enter Employee ID : ");
                            emp.eid = int.Parse(Console.ReadLine());
                            Console.Write("Enter Employee Name : ");
                            emp.ename = Console.ReadLine();
                            Console.Write("Enter Salary : ");
                            emp.esal = int.Parse(Console.ReadLine());
                            bl = new BusinessLogic();
                            if (bl.AddEmployee(emp))
                            {
                                Console.WriteLine("Employee Added");
                            }
                            else
                            {
                                Console.WriteLine("Employee Insertion Failed");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error Messagae :{ex.Message}");
                        }
                       

                        break;
                    case 2:
                        Console.Write("Enter Employee ID : ");
                        int eid = int.Parse(Console.ReadLine());
                        bl = new BusinessLogic();
                        if (bl.DeleteEmployee(eid))
                        {
                            Console.WriteLine("Employee Removed ...");
                           
                        }
                        else
                        {
                            Console.WriteLine("Employee Removal Failed...");
                        }
                    break;

                    case 3:
                        Console.Write("Enter Employee ID : ");
                        emp.eid = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Name : ");
                        emp.ename = Console.ReadLine();
                        Console.Write("Enter Salary : ");
                        emp.esal = int.Parse(Console.ReadLine());
                        bl = new BusinessLogic();
                        if (bl.UpdateEmployee(emp))
                        {
                            Console.WriteLine("Employee updated");
                          
                        }
                        else
                        {
                            Console.WriteLine("Employee updation Failed");
                        }
                        break;
                    case 4:
                        Console.Write("Enter Employee ID : ");
                        eid = int.Parse(Console.ReadLine());
                        bl = new BusinessLogic();
                        emp = bl.GetEmployee(eid);
                        Console.WriteLine("==========================Employee Info==================================");
                        Console.WriteLine($"Employee ID : {emp.eid}\nEmployee Name : {emp.ename}\nEmployee Salary : {emp.esal}");
                        Console.WriteLine("==========================================================================");
                        break;
                    case 5:
                        Console.WriteLine("=========================================================================");
                        Console.WriteLine("EmployeeID\t\tEmmployee Name\t\tEmploye Salary");
                        Console.WriteLine("=========================================================================");
                        bl =new BusinessLogic();
                        List<Employee> emplist = bl.GetEmployeeList();
                        foreach(Employee employee in emplist)
                        {
                            Console.WriteLine($"{employee.eid}\t\t\t{employee.ename}\t\t\t{employee.esal}");
                        }
                        Console.WriteLine("=========================================================================");
                        break;

                }
               
            }
        }
    }
}
