using Ex28.Entities;
using System;

namespace Ex28
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(080, "Wesley", 580.00);
            Account acc2 = new SavingsAccount(081, "Barbara", 580.00, 0.02);

            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);


            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
