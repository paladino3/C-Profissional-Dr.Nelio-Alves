using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Orientado_A_Objetos
{
    class Aluno
    {

        public string Nome { get; set; }
        public double Nota { get; set; }

        public double Resultado(double n1 , double n2, double n3)
        {

            return Nota += (n1 + n2 + n3);
        }

    }
}
