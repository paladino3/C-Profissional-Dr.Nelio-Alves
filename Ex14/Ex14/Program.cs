using System;
using System.Globalization;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero de entradas: ");
            int entrada = int.Parse(Console.ReadLine());

            double[] altura = new double[entrada];

            for (int i = 0; i < entrada; i++)
            {
                Console.Write("Qual e a altura: ");
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < entrada; i++)
            {
                soma += altura[i];
            }

            double media = soma / entrada;
            Console.WriteLine("A media das alturas sao: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
