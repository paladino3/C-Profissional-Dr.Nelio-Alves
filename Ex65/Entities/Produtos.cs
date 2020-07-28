using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex65.Entities
{
    class Produtos
    {
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + "Tipo: " + Categoria.Tipo + "Categoria nome: " + Categoria.NomeCategoria;
        }
    }
}
