using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Loan
    {
        protected int LoanId;
        protected string LoanName;
        protected int Duration;
        protected int RateOfInterst;
        public Loan()
        {

        }
        public Loan(int LoanId,string LoanName,int Duration, int RateOfInterst)
        {
            this.LoanId = LoanId;
            this.LoanName = LoanName;
            this.Duration = Duration;
            this.RateOfInterst = RateOfInterst;
        }
        public abstract void DisplayLoanInfo(); // abstract
       
        public void CaculateReateOfInt()  // non abstract methods
        {
            int rateofInfo = this.RateOfInterst * 5;
        }
        

    }
}
