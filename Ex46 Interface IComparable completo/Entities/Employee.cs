﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex46.Entities
{
    class Employee : IComparable
    {
        public string   Name     { get; set; }
        public double   Salary   { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vector = csvEmployee.Split(',');
            Name = vector[0]; //posicao 0, nome do funcionario
            Salary = double.Parse(vector[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            Employee other = obj as Employee;

            //return Name.CompareTo(other.Name); // por nome

            return Salary.CompareTo(other.Salary); // comparacao por salario

        }
    }
}
