using Ex60.Entities;
using System;
using System.Collections.Generic;

namespace Ex60
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Celular", 3900.00));
            list.Add(new Product("Tablet", 1900.00));
            list.Add(new Product("Ipad", 2900.00));
            list.Add(new Product("Maouse", 40.00));

            /*
            quero dar um incremento em 10%
            forma convencional
           
            foreach (Product item in list)
            {
                item.Price += item.Price * 0.10;

                Console.WriteLine(item);
            }
            */



            //list.ForEach(UpdatePrice);


            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(p => { p.Price += p.Price * 0.1; });

            list.ForEach(act);

            foreach (Product e in list)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
