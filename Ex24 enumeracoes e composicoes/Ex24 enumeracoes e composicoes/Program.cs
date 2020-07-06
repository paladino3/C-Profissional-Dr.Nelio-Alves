using Ex24_enumeracoes_e_composicoes.Entities;
using Ex24_enumeracoes_e_composicoes.Entities.Enums;
using System;

namespace Ex24_enumeracoes_e_composicoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}
