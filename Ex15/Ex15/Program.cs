using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            Produto[] vetorProduto = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetorProduto[i] = new Produto
                {
                    Nome = nome,
                    Preco = preco
                };
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetorProduto[i].Preco;
            }

            double avg = soma / n;
            Console.WriteLine("A media é:  " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
