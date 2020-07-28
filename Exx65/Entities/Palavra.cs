using System;
using System.Collections.Generic;
using System.Text;

namespace Exx65.Entities
{
    class Palavra
    {
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {

            return "\n" + Categoria.Nome + "            \t" + Nome;
        }
    }
}
