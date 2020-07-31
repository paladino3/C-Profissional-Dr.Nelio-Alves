using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex1.Entities
{
    class Invoice //Nota Fiscal
    {
        public Double BasicPayment { get; set; } //Pagamento basico
        public Double Tax { get; set; } //Tax

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public Double TotalPayment
        {
            get { return BasicPayment + Tax; }
        } //Pagamento Total

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
