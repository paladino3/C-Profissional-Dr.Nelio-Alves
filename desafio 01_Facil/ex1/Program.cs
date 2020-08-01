using System;
using System.Globalization;
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nome1 = Console.ReadLine();
            Console.Write("Quantos quartos voce tem em casa: ");
            int qtdQuarto = int.Parse(Console.ReadLine());
            Console.Write("Entre com o preco de um produto: ");
            double produtoPreco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu Nome, idade, Altura (mesma liha)");
            string[] vetor = Console.ReadLine().Split(',');
            string nome = vetor[0].Trim();
            int idade = int.Parse(vetor[1].Trim());
            double altura = double.Parse(vetor[2].Trim(), CultureInfo.InvariantCulture);


            Console.WriteLine("Nome Completo: " + nome1);
            Console.WriteLine("Quantidade de quartos: " + qtdQuarto);
            Console.WriteLine("Preço de um produto: " + produtoPreco);
            Console.WriteLine("Primeiro nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);

        }
    }
}
