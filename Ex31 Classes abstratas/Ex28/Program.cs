using Ex31.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex31
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Account acc1 = new Account(080, "Wesley", 580.00); nao funciona porque a classe e Abstract

            List<Account> accounts = new List<Account>(); // mesmo sendo abstract eu posso armazenar dentro de uma lista

            accounts.Add(new SavingsAccount(1001, "Wesley", 580.00, 0.01));
            accounts.Add(new BusinessAccount(1002, "Barbara", 500.00, 500.00));
            accounts.Add(new SavingsAccount(1003, "Roberto", 580.00, 0.01));
            accounts.Add(new BusinessAccount(1004, "Larissa", 500.00, 500.00));

       

            double soma = 0.0;

            //percorrendo contas na classe Account dentro da lista accounts
            foreach(Account contas in accounts)
            {
                soma += contas.Balance; //jogando os valores para a soma de todos os saldos
            }
            Console.WriteLine("Total Balance: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            //percorrendo contas na classe Account dentro da lista accounts
            foreach (Account contas in accounts)
            {
                contas.Withdraw(10.00); //percorrer o metodo de todas as contas e imprimindo na tela
                Console.WriteLine("Updated Balance for account: " + contas.Number + " Value $ "+  contas.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            //mesmo a classe mae Account estando abstrada eu posso instanciar uma lista, e acessar seus metodos e atributos
        }
    }
}
