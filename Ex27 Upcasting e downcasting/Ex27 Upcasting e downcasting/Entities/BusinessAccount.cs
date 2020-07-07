using System;
using System.Collections.Generic;
using System.Text;

namespace Ex27_Upcasting_e_downcasting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double banlance, double loanLimit)
            : base(number, holder, banlance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Banlance += amount;
            }
        }
    }
}
