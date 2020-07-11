using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio7_Orientado_A_ObjetosTraduzido
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += (Salario * (porcentagem / 100));
        }

        public override string ToString()
        {

            return Id +
                ", " +
                Nome +
                ", " +
                Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
