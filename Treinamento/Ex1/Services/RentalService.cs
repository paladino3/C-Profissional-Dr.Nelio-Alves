using Ex1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; } //Preco por hora
        public double PricePerDay { get; set; } // Preco por Dia

        // private BrazilTaxService _BrazilTaxService = new BrazilTaxService(); //Servico De Taxacao do Brasil
        private ITaxService _ITaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService iTaxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _ITaxService = iTaxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            //Calculations:
            double total = 0.0;
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //tempo gasto

            if (duration.TotalHours <= 12)
            {
                total = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                total = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _ITaxService.Tax(total);

            carRental.Invoice = new Invoice(total, tax);
        }
    }
}
