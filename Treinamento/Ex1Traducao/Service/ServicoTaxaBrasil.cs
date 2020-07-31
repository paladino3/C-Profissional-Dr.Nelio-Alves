using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Traducao.Service
{
    class ServicoTaxaBrasil : IServicoDeTaxa
    {
        public double Taxa(double quantia)
        {
            if (quantia <= 100.00)
            {
                return quantia * 0.20;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
