using System;

namespace Wesley
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] /*vetorDeLinha*/linha = Console.ReadLine().Split(','); // leio numero separados por virgula EX(3,3,3,3)
            int[] vector = new int[linha.Length]; // vetor de tamanho da linha 

            for (int i = 0; i < linha.Length; i++)
            {
                vector[i] = Convert.ToInt32(linha[i]);//
            }

            int c1 = Calculadora.Calular(vector);
            int c2 = Calculadora.Calular(3, 5, 9, 2);
            int c3 = Calculadora.Calular(25, 50);
            int c4 = Calculadora.Calular(0, 2520);
        }
    }
}
