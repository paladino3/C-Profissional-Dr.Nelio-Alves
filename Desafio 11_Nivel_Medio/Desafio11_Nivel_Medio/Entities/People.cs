using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio11_Nivel_Medio.Entities
{
     abstract class People
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected People(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes(); // metodo abstrado para impostos
    }
}
