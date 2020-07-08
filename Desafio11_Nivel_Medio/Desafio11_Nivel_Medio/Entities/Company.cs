using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio11_Nivel_Medio.Entities
{
    class Company : People
    {

        public int NumberOfEmployee { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployee)
            : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double Taxes()
        {
            if (NumberOfEmployee <= 10)
            {
                return (AnualIncome * 0.16);
            }
            else
            {
                return (AnualIncome * 0.14);
            }
        }
    }
}
