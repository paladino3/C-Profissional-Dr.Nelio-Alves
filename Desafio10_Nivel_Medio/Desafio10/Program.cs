using Desafio10.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>(); //lista de produtos


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nProduct #{i + 1} data: ");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c' || ch == 'C')
                {
                    products.Add(new Product(name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price,date));
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customs));
                }
            }
            Console.WriteLine("\n\nPRICE TAGS: ");
            foreach(Product prods in products)
            {
                Console.WriteLine(prods.PriceTag());
               
            }

        }
    }
}
