using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; // saldo rece o saldo, e multiplica pela taxa de juros
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // o base, repete as regras da funcao da classe principal 
            Balance -= amount; //alem de repetir a regra de negocio da classe mae, posso implementar novas regras na classe local!
        }
    }
}
