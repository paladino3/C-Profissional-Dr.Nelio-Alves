using Ex1.Entities;
using Ex1.Services;
using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your rental data");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy  hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy  hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             CarRental c1 = new CarRental() { Vehicle = new Vehicle { Model = carModel }, Start = start, Finish = finish };
           // CarRental c1 = new CarRental(start, finish, new Vehicle(carModel));

           // RentalService rental = new RentalService() { PricePerHour = priceHour, PricePerDay = priceDay, };
           RentalService rental = new RentalService(priceHour, priceDay, new BrazilTaxService());


            rental.ProcessInvoice(c1);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(c1.Invoice);

        }
    }
}
