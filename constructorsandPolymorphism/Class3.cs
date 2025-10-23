using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.ShowCompanyDetails();

            Company company1 = new Company(111,"ABC Corp","Mumbai");
            company1.ShowCompanyDetails();

            Company company2 = new Company(112, "Microsoft Corp", "USA");
            company2.ShowCompanyDetails();


            Company company3 = new Company(company1);
            company3.ShowCompanyDetails();







        }
    }
}
