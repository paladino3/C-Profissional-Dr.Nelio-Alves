using Desafio8_Nivel_Medio.Entities;
using Desafio8_Nivel_Medio.Entities.Enums;
using System;
using System.Globalization;

namespace Desafio8_Nivel_Medio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter departmenet's name: ");
            string dpName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string wkName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel wkLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // instancia de department
            Department dept = new Department(dpName);

            // instanciando work e relacionando work com department
            Worker work = new Worker(wkName, wkLevel, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int durationHours = int.Parse(Console.ReadLine());


                //intanciando um novo contrato, com data, valorHora, e duracao
                HourContract contract = new HourContract(date, valueHour, durationHours);

                //adcionar um contrato para um trabalhador
                work.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + work.Name);
            Console.WriteLine("Department: " + work.Department.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + work.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
