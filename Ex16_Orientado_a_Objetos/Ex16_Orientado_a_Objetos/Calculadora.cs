using System;
using System.Collections.Generic;
using System.Text;

namespace Ex16_Orientado_a_Objetos
{
    class Calculadora
    {
        public static int Soma(params int[] numero)
        {
            int soma = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                soma += numero[i];
            }
            return soma;
        }

    }
}
