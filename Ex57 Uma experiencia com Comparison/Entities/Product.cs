using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ex57.Entities
{
    class Product

    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
/*
        public int CompareTo([AllowNull] Product obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Um erro relativo");
            }
            Product other = obj as Product;

            return Price.CompareTo(other.Price);
        }
*/
        public override string ToString()
        {
            return Name + ", " + Price;
        }
    }
}
