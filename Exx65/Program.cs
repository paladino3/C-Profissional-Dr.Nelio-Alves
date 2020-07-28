using Exx65.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exx65
{
    class Program
    {
        static void Main(string[] args)
        {


            Categoria c1 = new Categoria { Nome = "Eletronicos", Tipo = 1 };
            Categoria c2 = new Categoria { Nome = "Ferramentas", Tipo = 2 };
            Categoria c3 = new Categoria { Nome = "Carro", Tipo = 3 };


            List<Palavra> produtos = new List<Palavra>()
            {
              new Palavra() {Nome = "Astra", Categoria = c3 },
              new Palavra() {Nome = "Bmw",  Categoria = c3 },
              new Palavra() {Nome = "C180", Categoria = c3 },
              new Palavra() {Nome = "Alicate", Categoria = c2 },
              new Palavra() {Nome = "Bisturi",  Categoria = c2 },
              new Palavra() {Nome = "Compressor",  Categoria = c2 },
              new Palavra() {Nome = "AirPods", Categoria = c1 },
              new Palavra() {Nome = "Baba eletrônica",Categoria = c1 },
              new Palavra() {Nome = "Caixa de som Genius", Categoria = c1 },
            };


            Console.Write("Letra: ");
            char valor1 = char.Parse(Console.ReadLine().ToUpper());

            var consulta = produtos.Where(x => x.Nome[0] == valor1);

            Console.WriteLine("\nCATEGORIA" + "\t\tNOME\n");
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

        }
    }
}
