using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace D13.Entities
{
    class Installment                                       //PARCELAS
    {
        public DateTime     DueDate      { get; set; }      //data de vencimento 
        public double       Amount       { get; set; }      // quantidade

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") +
                " - " +
                Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
