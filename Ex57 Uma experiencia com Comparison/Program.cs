using Ex57.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Ex57
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("PC", 3200.00));
            list.Add(new Product("Notebook", 2900.00));
            list.Add(new Product("Monitor", 1900.00));


            //Comparison<Product> comparacao = CompareProducts;
            //    list.Sort(CompareProducts);
            //    list.Sort(comparacao);


            //expressao lambda
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product e in list)
            {
                Console.WriteLine(e.ToString());
            }
        }
        //metodo fora do escopo do void Main
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
