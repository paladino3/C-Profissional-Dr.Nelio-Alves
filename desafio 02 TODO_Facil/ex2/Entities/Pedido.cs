using System;
using System.Collections.Generic;
using System.Text;

namespace ex2.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public string Resumo { get; set; }
        public double Total { get; set; }
        public Lanche Lanche { get; set; }

        public override string ToString()
        {
            return "" + Lanche.Cod + "" + Lanche.Nome + "" + Lanche.Preco;
        }



   
    }
}
