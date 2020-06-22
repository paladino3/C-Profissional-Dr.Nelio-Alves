using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace desafio3
{
    class Program
    {

        static void Main(string[] args)
        {
            /* 
              Pessoa p1 = new Pessoa();
              Pessoa p2 = new Pessoa();

              Console.WriteLine("Dados da primeira pessoa: ");
              Console.Write("Nome: ");
              p1.nome = Console.ReadLine();
              Console.Write("Idade: ");
              p1.idade = int.Parse(Console.ReadLine());



              Console.WriteLine("Dados da segunda pessoa: ");
              Console.Write("Nome: ");
              p2.nome = Console.ReadLine();
              Console.Write("Idade: ");
              p2.idade = int.Parse(Console.ReadLine());


              if (p1.idade > p2.idade)
              {
                  Console.WriteLine("Pessoa mais velha: "+p1.nome);
              }
              else
              {
                  Console.WriteLine("Pessoa mais velha: " + p2.nome);
              }

      */


            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
