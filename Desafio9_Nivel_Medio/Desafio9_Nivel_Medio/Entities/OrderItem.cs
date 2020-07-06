﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio9_Nivel_Medio.Entities
{
    class OrderItem
    {
        public int          Quantity        { get; set; }
        public double       Price           { get; set; }
        public Product      Product         { get; set; } //relacao 1 para 1


        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, price)
        {
            Product = product;
        }

        public double SubTotal()
        {
           return Quantity * Price;
        }
    }
}
