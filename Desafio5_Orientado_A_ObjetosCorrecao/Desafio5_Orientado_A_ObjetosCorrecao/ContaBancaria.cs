using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio5_Orientado_A_ObjetosCorrecao
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
             this.Saldo += quantia;

        }

        public void Saque(double quantia)
        {
            this.Saldo -= quantia + 5.0;

        }

        //fazendo o toString
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
