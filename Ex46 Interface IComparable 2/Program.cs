using Ex46.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ex46
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 14 Interfaces\Interface_IComparable\ex2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> emp = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        emp.Add(new Employee(sr.ReadLine()));
                    }
                    emp.Sort();

                    foreach (Employee employee in emp)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }

        }
    }
}
