using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio11_Nivel_Medio.Entities
{
    class Individual : People
    {
        public double TaxHealth { get; set; }

        public Individual(double taxHealth, string name, double anualIncome)
            : base(name, anualIncome)
        {
            TaxHealth = taxHealth;
        }

        public override double Taxes()
        {
            if (AnualIncome <= 20.000)
            {
                double tax = 0.0;
                double care = 0.0;
                tax += (AnualIncome * 0.15);
                if (TaxHealth > 0)
                {
                    care += (TaxHealth * 0.50);
                }
                else
                {
                    return tax;
                }

                return (tax - care);
            }
            else
            {
                double tax = 0.0;
                double care = 0.0;

                tax += (AnualIncome * 0.25);
                if (TaxHealth > 0)
                {
                    care += (TaxHealth * 0.50);
                }
                else
                {
                    return tax;
                }
                return (tax - care);
            }
        }
    }
}
