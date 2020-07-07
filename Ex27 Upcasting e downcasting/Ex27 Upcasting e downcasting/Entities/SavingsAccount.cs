using System;
using System.Collections.Generic;
using System.Text;

namespace Ex27_Upcasting_e_downcasting.Entities
{
    class SavingsAccount : Account
    {
        public double IterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double banlance, double iterestRate)
            : base ( number,  holder,  banlance)
        {
            IterestRate = iterestRate;
        }


        public void UpdateBalance()
        {
            Banlance += Banlance * IterestRate;
        }
    }
}
