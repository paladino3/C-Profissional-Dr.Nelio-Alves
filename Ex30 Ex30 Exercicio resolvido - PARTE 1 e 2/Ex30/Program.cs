using Ex30.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());


            List<Employee> employees = new List<Employee>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                string resp = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (resp.ToLower() == "y")
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee f2 = new OutSourcedEmployee(name, hours, value, additional);
                    employees.Add(f2);

                    // ou  list.Add(new OutSourcedEmployee(name, hours, value, additional));
                }
                else if (resp.ToLower() == "n")
                {
                    Employee f1 = new Employee(name, hours, value);
                    employees.Add(f1);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            Console.WriteLine("\nPAYMENTS: ");
            foreach (Employee func in employees)
            {
                Console.WriteLine(func.Name + " - $ " + func.Payment().ToString("F2"), CultureInfo.InvariantCulture);

            }
        }
    }
}
