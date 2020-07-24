using Ex63.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex63
{
    class Program
    {


        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };



            List<Product> products = new List<Product>() {

            new Product() { Id = 1, Name = "Computer", Price = 1100.00, Category = c2 },
            new Product() { Id = 2, Name = "Hammer", Price = 90.00, Category = c1 },
            new Product() { Id = 3, Name = "TV", Price = 1800.00, Category = c3 },
            new Product() { Id = 4, Name = "Notebook", Price = 1100.00, Category = c2 },
            new Product() { Id = 5, Name = "SAW", Price = 80.00, Category = c1 },
            new Product() { Id = 6, Name = "Tablet", Price = 700.00, Category = c2 },
            new Product() { Id = 7, Name = "Camera", Price = 140.00, Category = c3 },
            new Product() { Id = 8, Name = "Printer", Price = 1100.00, Category = c3 },
            new Product() { Id = 9, Name = "MackBook", Price = 1600.00, Category = c2 },
            new Product() { Id = 10, Name = "Sound Bar", Price = 2100.00, Category = c3 },
            new Product() { Id = 11, Name = "Level", Price = 90.00, Category = c1 }

        };

            //expression

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price <= 900);
            Print("TIER 1 AND PRICE < 900.00", r1);


            //filtrando o obj por categoria ferramente, e o select pega o obj e filtra pelo nome
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of products from tools!", r2);

            //posso criar um objeto anonimo, com meus proprios parametros, como ha dois nome, tive que dar um apelido para o obj(alias)
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { ProductName = p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names started whit 'C' and anonymous onject", r3);

            //Pegando os tier == 1. e ordenando por preco e tambem nome! muito foda
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 oder by Price and Name", r4);

            //Pega os elementos de r4 e pula os dois primeiro obj e pega os 4 finais
            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 oder by Price and Name SKIP 2 TAKE 4", r5);

            //Pegando o primeiro valor
            var r6 = products.First();
            Console.WriteLine("First teste 1: " + r6);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("First teste FirstOrDefault 2: " + r7);
            Console.WriteLine();


            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SingleOrDefault teste1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SingleOrDefault teste2: " + r9);
            Console.WriteLine();

            var r10 = products.Where(p => p.Id > 0).OrderBy(p => p.Price).ThenBy(p => p.Name).ThenBy(p => p.Id);
            Print("Meu experimento, ordenando multiplos itens!", r10);

        }
    }


}
