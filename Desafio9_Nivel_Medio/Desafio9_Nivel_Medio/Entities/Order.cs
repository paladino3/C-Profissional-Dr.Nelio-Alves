using Desafio9_Nivel_Medio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio9_Nivel_Medio.Entities
{
    class Order
    {
        public DateTime             Moment          { get; set; }
        public OrderStatus          Status          { get; set; }
        public Client               Client          { get; set; }
        public List<OrderItem>      Items           { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(OrderItem total)
        {
            return total.SubTotal();
        }

    }
}
