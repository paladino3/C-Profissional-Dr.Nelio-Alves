using Ex61.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex61
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Product> list = new List<Product>();

            list.Add(new Product("Ipad", 2300.00));
            list.Add(new Product("Tv led", 1300.00));
            list.Add(new Product("Imac", 8000.00));
            list.Add(new Product("Tv lcd", 1000.00));
            list.Add(new Product("Ar condicionado", 2300.00));


            Func<Product, string> func = NameUpper;

            Func<Product, string> func2 = p => p.Name.ToUpper();

            List<string> resultado = list.Select(NameUpper).ToList();

            List<string> resultado2 = list.Select(func2).ToList();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            /*
                        foreach(Product e in list)
                        {
                            Console.WriteLine(e.ToString());
                        }
            */

            foreach (var e in result)
            {
                Console.WriteLine(e.ToString());
            }

        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
