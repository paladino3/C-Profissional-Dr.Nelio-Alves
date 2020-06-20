using System;
using System.Globalization;
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Quantos quartos voce tem em casa: ");
            int qtdQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double produtoPreco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu Nome, idade, Altura (mesma liha)");
            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome1);
            Console.WriteLine(qtdQuarto);
            Console.WriteLine(produtoPreco);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
