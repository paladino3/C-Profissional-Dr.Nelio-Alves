using Ex65.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Ex65
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

            Category c1 = new Category() { Id = 01, Name = "Eletrônicos", Tier = 3 }; //Eletrônicos
            Category c2 = new Category() { Id = 02, Name = "Ferramentas", Tier = 2 }; //Ferramentas
            Category c3 = new Category() { Id = 03, Name = "Vestuario", Tier = 1 }; //Vestuario
            Category c4 = new Category() { Id = 04, Name = "Comida", Tier = 1 };//Comida


            List<Products> products = new List<Products>()
            {
                new Products() { Id =1 , Name = "Ipad", Price = 1900, Category = c1},
                new Products() { Id =10 , Name = "Alicate", Price = 80, Category = c2},
                new Products() { Id =11 , Name = "Blusa", Price = 33, Category = c3},
                new Products() { Id =3 , Name = "Regata", Price = 20, Category = c3},
                new Products() { Id =5 , Name = "Celular", Price = 1800, Category = c1},
                new Products() { Id =9 , Name = "Computador, Mouse", Price = 3500, Category = c1},
                new Products() { Id =12 , Name = "Coca-cola", Price = 5.50, Category = c4},
                new Products() { Id =2 , Name = "Empada", Price = 3.5,  Category = c4},
                new Products() { Id =02 , Name = "Martelo", Price = 40.0,  Category = c2}
            };

            var r1 = products.Where(x => x.Price < 100);
            Print("R1\t Preco menor que 100", r1);

            var r2 = products.Where(x => x.Name[0] == 'A').Select(x => x.Name);
            Print("R2\tProdutos que começa com a letra A", r2);


            var r3 = products.Where(x => x.Price < 100 && x.Category.Tier == 1);
            Print("R3\tPreco menor que 100 e Tier == 1 ", r3);


            var r4 =
                from p in products // na "Tabela produtos" p
                where p.Price < 100 && p.Category.Tier == 1 //condicao
                select p; // projecao

            Print("R4\tSelect do r3", r4);

            var r5 =
                from p in products
                where p.Category.Name == "Ferramentas"
                select p.Name;

            Print("R5\t Pegando todos os produtos da categoria ferramentas! ", r5);

            var r6 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoriaNome = x.Category.Name });

            Print("Produtos que comecam com a letra C, e instanceando esse obj", r6);

            var r7 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoriaNome = p.Category.Name //tenho que colocar o apelido porque tem dois NAME
                };
            Print("Produtos que comecam com a letra C, e instanceando esse obj", r7);

            var r8 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(x => x.Name).ThenBy(x => x.Id);
            Print("Produtos da tabela com Tier == 1! ordenados por preços e nome", r8);

            var r9 =
                from p in products
                where p.Category.Tier == 1
                //macete colocar na ordem inversa
                orderby p.Name
                orderby p.Price
                select p;
            Print("Produtos da tabela com Tier == 1! ordenados por preços e nome", r9);

            var r10 = r9.Skip(2).Take(4);
            Print("Tier 1 order by price then by name skip 2 take 4", r10);

            var r11 = (from p in r9
                       select p).Skip(2).Take(4);
            Print("Tier 1 order by price then by name skip 2 take 4", r11);

            //agrupamentos de categoria mais importante 

            var r12 = products.GroupBy(p => p.Category);
            foreach (var grupoCategoria in r12)
            {
                Console.WriteLine("Category " + grupoCategoria.Key.Name + ":\n");
                foreach (var nomeDasCategorias in grupoCategoria)
                {
                    Console.WriteLine(nomeDasCategorias);
                }
            }

            Console.WriteLine("\n\n");

            var r13 = from p in products
                      group p by p.Category;

            foreach(var grupoCat in r13)
            {
                Console.WriteLine("\nCategoria " + grupoCat.Key.Name + ":");
                foreach(var nomeCat in grupoCat)
                {
                    Console.WriteLine(nomeCat);
                }
            }

        }
    }
}
