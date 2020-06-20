using System;
using System.Globalization;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade = 30;
            int cod = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");


            Console.WriteLine($"Registro: {idade} anos de idade, código {cod} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondamento (tres casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant Culture: {medida:F3}");

        }

    }
}
