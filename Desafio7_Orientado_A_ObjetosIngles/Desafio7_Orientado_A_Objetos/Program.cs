using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Desafio7_Orientado_A_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> listEmployee = new List<Employee>(); //criando uma nova lista de Funcionario

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("\nEmplyoee #{0}:", i + 1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployee.Add(new Employee(id, name, salary)); // criando um novo funcionario
            }

            Console.Write("\n\nEnter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = listEmployee.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalaray(percentage);
            }
            else
            {
                Console.Write("This id does not exist!\n");
            }

            Console.WriteLine("\nUpdated list of employees: ");
            foreach(Employee obj in listEmployee)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
