using System;
using System.Collections.Generic;
using System.Text;

namespace Exx65.Entities
{
    class Categoria
    {
        public string Nome { get; set; }
        public int Tipo { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
