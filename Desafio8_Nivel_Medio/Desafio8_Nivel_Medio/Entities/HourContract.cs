using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Desafio8_Nivel_Medio.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return this.ValuePerHour * this.Hours;
        }
    }
}
