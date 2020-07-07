using System;
using System.Collections.Generic;
using System.Text;

namespace Ex27_Upcasting_e_downcasting.Entities
{
    class Account
    {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Banlance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double banlance) 
        {
            Number = number;
            Holder = holder;
            Banlance = banlance;
        }


        public void Withdraw(double amount)
        {
            Banlance -= amount;
        }

        public void Deposit(double amount)
        {
            Banlance += amount;
        }
    }
}
