using Ex67.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Ex67
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            /*
             * C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seção 17 Expressoes lambda, delegates, LINQ\Funcionarios.txt
            */

                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();
                Console.Write("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                List<Employee> list = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        string name = vect[0];
                        string email = vect[1];
                        double salaryRead = double.Parse(vect[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salaryRead));
                    }
                }

                var highSalayEmail = list.Where(x => x.Salary > 2000).OrderBy(x => x.Email).Select(x => x.Email);

                Console.WriteLine("\nEmail of people whose salary is more than {0}:", salary.ToString("F2", CultureInfo.InvariantCulture));

                foreach (var item in highSalayEmail)
                {
                    Console.WriteLine(item);
                }
                var sum = list.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

                

            }
            catch (Exception error)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(error);
            }
        }
    }
}
