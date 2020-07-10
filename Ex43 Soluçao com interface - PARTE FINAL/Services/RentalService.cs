using Ex43.Entities;
using Ex43_Parte3.Services;
using System;
namespace Ex43.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }


        // private BrazilTaxService _BrazilTaxService = new BrazilTaxService();

        private ITaxService _textService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService textService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _textService = textService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _textService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
