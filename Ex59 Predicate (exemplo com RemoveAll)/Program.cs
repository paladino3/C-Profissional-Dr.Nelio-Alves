using Ex59.Entities;
using System;
using System.Collections.Generic;

namespace Ex59
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            list.Add(new Products("ESPELHO", 100.00));
            list.Add(new Products("TV", 900.00));
            list.Add(new Products("PC", 3900.00));
            list.Add(new Products("DVD", 9.00));
            list.Add(new Products("MOUSE", 45.00));
            list.Add(new Products("TABLET", 2345.00));

            //removendo produtos que tenha valores maiores que 100 ou superior
            //list.RemoveAll(x => x.Price >= 100);


            list.RemoveAll(ProductTeste);

            foreach(Products item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static bool ProductTeste(Products p)
        {
            return p.Price >= 100;
        }
    }
}
