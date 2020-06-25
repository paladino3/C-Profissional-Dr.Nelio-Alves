using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace Ex014
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());

            double[] vetor = new double[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                soma += vetor[i];
            }

            double media = soma / tamanho;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}