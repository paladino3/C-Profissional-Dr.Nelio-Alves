using Desafio11_Nivel_Medio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio11_Nivel_Medio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<People> list = new List<People>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nTax payer #{i + 1} data: ");

                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double Taxeshealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(Taxeshealth, name, income));
                }
                else if (ch == 'c' || ch == 'C')
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, number));
                }
            }

            Console.WriteLine("\n\nTAXES PAID: ");
            foreach (People p in list)
            {
                Console.WriteLine(p.Name + ": $ " + p.Taxes().ToString("F2", CultureInfo.InvariantCulture));

            }
            double totalTaxes = 0;

            foreach (People p in list)
            {
                totalTaxes += p.Taxes();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
