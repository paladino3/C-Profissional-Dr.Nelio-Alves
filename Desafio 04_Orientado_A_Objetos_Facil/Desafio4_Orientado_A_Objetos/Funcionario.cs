using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio4_Orientado_A_Objetos
{
    class Funcionario
    {

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto  { get; set; }

        public double SalarioLiquido()
        {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double total = 0;
            total += ((this.SalarioBruto * porcentagem) / 100);

            this.SalarioBruto += total;

        }


        public void AtualizarDados()
        {
        Console.WriteLine("Dados atualizados: {0}, $ {1}", this.Nome, this.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
