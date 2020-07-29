﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex65.Entities
{
    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }


        public override string ToString()
        {
            return Id + ", " + Name + ", " + Price + ", " + Category.Name + ", " + Category.Tier;  
        }
    }
}
