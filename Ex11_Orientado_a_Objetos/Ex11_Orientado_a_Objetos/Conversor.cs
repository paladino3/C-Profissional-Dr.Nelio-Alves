using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ex11_Orientado_a_Objetos
{
    class Conversor
    {
        public static double imposto = 0.06;
        public static double resultado = 0;
        public static double Converter(double dolar, double qtde)
        {
            return Conversor.resultado += ((dolar * imposto) + dolar)* qtde;
        }
    }
}
