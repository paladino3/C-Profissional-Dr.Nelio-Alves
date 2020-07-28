using Ex65.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ex65
{
    class Program
    {
        static void Main(string[] args)
        {


            Categoria c1 = new Categoria { NomeCategoria = "Eletronicos", Tipo = 1 };
            Categoria c2 = new Categoria { NomeCategoria = "Ferramentas", Tipo = 2 };
            Categoria c3 = new Categoria { NomeCategoria = "Carro", Tipo = 3 };


            List<Produtos> produtos = new List<Produtos>()
            {
              new Produtos() {Nome = "Astra", Categoria = c3 },
              new Produtos() {Nome = "Bmw",  Categoria = c3 },
              new Produtos() {Nome = "C180", Categoria = c3 },
              new Produtos() {Nome = "Alicate", Categoria = c2 },
              new Produtos() {Nome = "Bisturi",  Categoria = c2 },
              new Produtos() {Nome = "Compressor",  Categoria = c2 },
              new Produtos() {Nome = "AirPods", Categoria = c1 },
              new Produtos() {Nome = "Baba eletrônica",Categoria = c1 },
              new Produtos() {Nome = "Caixa de som Genius", Categoria = c1 },
            };

            char valor1 = char.Parse(Console.ReadLine().ToUpper());


            var consulta = produtos.Where(x => x.Categoria == c1 && x.Nome[0] == valor1);


            foreach (var item in consulta)
            {

                Console.WriteLine(item);
            }



        }
    }
}
