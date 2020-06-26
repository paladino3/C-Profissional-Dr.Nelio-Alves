using System;
using System.Collections.Generic;
using System.Text;

namespace Wesley
{
    class Calculadora
    {
        public static int Calular(params int[] numero) // metodo de calcular um vetor de numeros inteiros!
        {
            int soma = 0; // variavel aux
            for (int i = 0; i < numero.Length; i++) // enquanto i for menor que o tamanho do vetor. Eu somo jogo o valor na variavel aux
            {
                soma += numero[i];
            }
            Console.WriteLine(soma);
            return soma;
        }
    }
}
