using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Traducao.Entities
{
    class AluguelDeCarros
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public Veiculo Veiculo { get; set; }
        public NotaFiscal NotaFiscal { get; set; }


    }
}
