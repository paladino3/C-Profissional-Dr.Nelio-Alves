using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Text;

namespace ordernar.Entities
{
    class Funcionario : IComparable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Funcionario(string Cv_func)
        {
            string[] vector = Cv_func.Split(',');
            Name = vector[0];
            Id = int.Parse(vector[1]);
            Salary = double.Parse(vector[2], CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Funcionario other = obj as Funcionario;

            //  return Name.CompareTo(other.Name);
            //  return Id.CompareTo(other.Id);
             return Salary.CompareTo(other.Salary);
        }


        public override string ToString()
        {
            return "Name: " + Name +
                "Id: " + Id +
                "Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
