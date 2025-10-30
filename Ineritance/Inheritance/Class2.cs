using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PersonalLoan : Loan
    {
        public override void DisplayLoanInfo()
        {
            throw new NotImplementedException();
        }
    }
    class EducationLoan : Loan
    {
        string EduType;
        int WaitDuration;

        public override void DisplayLoanInfo() // this is the abstract method from Loan class defined the child class 
        {
            Console.WriteLine($"ID : {this.LoanId} LoanName : {this.LoanName}   Eduction Type : {EduType}\tWaitingDuration : {WaitDuration}");
        }
        public EducationLoan(string EduType,int WaitDuration,int LoanId,string LoanName,int Duration,int RateOfInterst)
        {
            this.EduType    = EduType;
            this.WaitDuration = WaitDuration;
            this.LoanId = LoanId;
            this.LoanName = LoanName;
            this.Duration = Duration;
            this.RateOfInterst = RateOfInterst;

        }
        public void GetEduLoanInfo(string EduType,int WatingDuration)
        {
            this.EduType= EduType;
            this.WaitDuration= WatingDuration;
        }
        
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
          EducationLoan loan = new EducationLoan("Medicine",5,3456,"Educion Loan",8,3);
            loan.GetEduLoanInfo("Medicine", 5); // Eduction Loan
            loan.DisplayLoanInfo();  //Loan Abstract method
            loan.CaculateReateOfInt(); //
        }
    }
}
