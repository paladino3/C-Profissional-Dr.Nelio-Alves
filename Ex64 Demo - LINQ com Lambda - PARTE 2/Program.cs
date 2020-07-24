using Ex64.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;

namespace Ex64
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
            /*
                        var r10 = products.Where(p => p.Id > 0).OrderBy(p => p.Price).ThenBy(p => p.Name).ThenBy(p => p.Id);
                        Print("Meu experimento, ordenando multiplos itens!", r10);
            */

            //  var r10 = products.Max().Price;//sem parametros eu preciso que seja implementado o Icomparable

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum price: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Avarage prices: " + r13.ToString("F2", CultureInfo.InvariantCulture));


            // var r13 = products.Where(p => p.Category.Id == 120).Average(p => p.Price); categoria que nao existe

            var r14 = products.Where(p => p.Category.Id == 120).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Average com protecao contra valores nulos
            Console.WriteLine("Category 120 Avarage prices: " + r14.ToString("F2", CultureInfo.InvariantCulture));

            // MAP  E  REDUCEEEEEEE


            //Select = MAP
            //Aggregate = REDUCE
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate sum: " + r15);

            //protecao contra ZERO
            var r16 = products.Where(p => p.Category.Id == 120).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 120 Aggregate sum: " + r16.ToString("F2", CultureInfo.InvariantCulture)); ;

            Console.WriteLine();
            var r17 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
