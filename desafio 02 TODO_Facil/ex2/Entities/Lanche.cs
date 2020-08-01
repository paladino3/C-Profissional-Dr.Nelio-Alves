using System;
using System.Collections.Generic;
using System.Text;

namespace ex2.Entities
{
    class Lanche
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Lanche(int cod, string nome, double preco)
        {
            Cod = cod;
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "" + Cod + "" + Nome + "" + Preco;
        }
    }
}
