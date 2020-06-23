using System;

namespace Ex13_Orientado_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string produto = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produtos = new Produto(produto, preco, quantidade);
            Produto p1 = new Produto(produto, preco);
            Produto p2 = new Produto();


            p1.Nome = "Cafe";
            


            p1.AtualizarDados();

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
