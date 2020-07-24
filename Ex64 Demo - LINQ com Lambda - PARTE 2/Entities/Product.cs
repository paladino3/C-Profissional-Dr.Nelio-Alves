using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex64.Entities
{
    class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public int CompareTo(object obj)
        {

            if (!(obj is Product))
            {
                throw new Exception("um erro ocorreu.");
            }

            Product other = obj as Product;

            return Price.CompareTo(other.Price);

        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                 + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                 + ", "
                + Category.Name
                 + ", "
                + Category.Tier;
        }

    }
}
