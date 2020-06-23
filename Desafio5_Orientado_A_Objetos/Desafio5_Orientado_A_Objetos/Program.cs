using System;

namespace Desafio5_Orientado_A_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Entre com o numero da conta: ");
            int nc = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            ContaBancaria cb = new ContaBancaria(nc, titular);

            Console.Write("Havera deposito inicial (s/n)? ");
            string resp = Console.ReadLine();
            cb.Saldo = 0;    
            cb.DepositoInicial(resp);
            Console.WriteLine("\n\nDados da Conta:");
            cb.AtualizarDados();

            Console.Write("\n\nEntre com um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            cb.Deposito(valorDeposito);

            cb.AtualizarDados();

            Console.Write("\n\nEntre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            cb.Saque(valorSaque);
            cb.AtualizarDados();
        }
    }
}
