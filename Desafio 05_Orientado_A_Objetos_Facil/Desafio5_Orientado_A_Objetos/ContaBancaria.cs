using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desafio5_Orientado_A_Objetos
{
    class ContaBancaria
    {

        public string Nome { get; set; }
        public double Saldo { get; set; }
        public int Ncc { get; set; }

        public ContaBancaria(int ncc, string nome)
        {
            Ncc = ncc;
            Nome = nome;
        }

        public ContaBancaria(int ncc, string nome, double saldo)
        {
            Ncc = ncc;
            Nome = nome;
            Saldo = saldo;
        }

        public double Deposito(double valor)
        {
            return this.Saldo += valor;
        }

        public double Saque(double valor)
        {
            double Taxa = 5;
            this.Saldo -= Taxa;
            return this.Saldo -= valor;
        }

        public void DepositoInicial(string resposta)
        {
            if (resposta == "s".ToLower())
            {
                Console.Write("\n\nEntre com o valor de deposito inicial: ");
                double valor = double.Parse(Console.ReadLine());

                this.Deposito(valor);
            }
        }
/*
        public override string ToString()
        {
            return "\n\nDados da conta: \nConta " + this.Ncc + ", Titular: " + this.Nome + ", Saldo: $ " + this.Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
      */
   
        public void AtualizarDados()
        {
            Console.WriteLine("Conta " + this.Ncc + ", Titular: " + this.Nome + ", Saldo: $ " + this.Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
  
    }
}
