using Ex9_Orientado_a_Objetos;
using System;
using System.Runtime.CompilerServices;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produtos = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produtos.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produtos.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produtos.Quantidade = int.Parse(Console.ReadLine());

            produtos.AtualizarDados();

            Console.Write("\nDigite um numero de produtos a ser adicionado em estoque: ");
            int add = int.Parse(Console.ReadLine());
            produtos.AdicionarProdutos(add);

            produtos.AtualizarDados();

            Console.Write("\nDigite um numero de produtos  a ser removido do estoque: ");
            int remove = int.Parse(Console.ReadLine());
            produtos.RemoverProdutos(remove);

            produtos.AtualizarDados();
        }

      
    }
}
