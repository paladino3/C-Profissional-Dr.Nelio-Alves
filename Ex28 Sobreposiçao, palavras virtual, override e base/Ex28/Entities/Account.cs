using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }
    }
}
