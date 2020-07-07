using Desafio9_Nivel_Medio.Entities;
using Desafio9_Nivel_Medio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio9_Nivel_Medio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            Client client = new Client(name,email,date); 
            Order os = new Order(DateTime.Now, orderStatus, client); // relacionando o cliente com a  ordem de servico




            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product prod = new Product(pName, pPrice);
                
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                //relacionando pedidos items com o produto
                OrderItem osItem = new OrderItem(pQuantity, pPrice, prod);

                os.AddItem(osItem);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(os);
        }
    }
}
