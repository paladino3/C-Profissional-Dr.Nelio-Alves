using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Desafio5_Orientado_A_ObjetosCorrecao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb; //objeto


            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                cb = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\n\nDados da conta:");
            Console.WriteLine(cb);

            Console.Write("\n\nEntre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);

            Console.Write("\n\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);


        }
    }
}
