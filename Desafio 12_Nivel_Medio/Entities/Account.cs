﻿using D12.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace D12.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainExceptions("Erro para efetuar o saque, Saldo insuficiente!");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("Erro para efetuar o saque, quantia requerida maior que o limit de saque!");
            }

            Balance -= amount;
        }


        public override string ToString()
        {
            return "New balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
