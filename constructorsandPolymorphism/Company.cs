using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Company
    {
        int CompanyId;
        string CompanyName;
        string Address;     // Private and non static members which can't be accessed outside
        
        static Company()
        {
            Console.WriteLine("Hi Iam static constructor");
        }
       
        public Company()
        {
            Console.WriteLine("Hi Iam constructor without parameter");
        }

        public Company(int CompanyId,string CompanyName,string Address)
        {
            Console.WriteLine("constructor with paramters");
            this.CompanyId = CompanyId;
            this.CompanyName = CompanyName;
            this.Address = Address;
        }

        public Company(Company company)
        {
            Console.WriteLine("Hi Iam Copy Constructor");
            this.CompanyId=company.CompanyId;
            this.CompanyName=company.CompanyName;
            this.Address=company.Address;
        }

        ~Company()
        {
            
        }
        public void ShowCompanyDetails()
        {
            Console.WriteLine($"ID :{CompanyId}\nName:{CompanyName}\nAddress : {Address}");
        }

    }
}
