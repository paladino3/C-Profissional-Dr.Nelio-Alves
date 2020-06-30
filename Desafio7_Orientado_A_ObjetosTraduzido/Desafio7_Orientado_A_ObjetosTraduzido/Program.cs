using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio7_Orientado_A_ObjetosTraduzido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serao registrados? ");
            int numero = int.Parse(Console.ReadLine());

            List<Funcionario> listaFunc = new List<Funcionario>(); // criando uma lista de funcionario

            for (int i = 0; i < numero; i++)
            {
                Console.Write("\nFuncionario #{0}:\n", i + 1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = (Console.ReadLine());
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // armazenar os dados na listaFunc
                listaFunc.Add(new Funcionario(id, nome, salario)); //criando um novo funcionario, dentro da listaFunc
            }

            Console.Write("\nEntre com o id do funcionario que vai receber um incremento no salario: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario funcId = listaFunc.Find(x => x.Id == procurarId);
            if (funcId != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcId.IncrementarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("\nO id Informado nao foi existe!\n"); 
            }


            Console.WriteLine("\nLista atualizada de funcionarios: ");
            foreach(Funcionario objFunc in listaFunc)
            {
                Console.WriteLine(objFunc);
            }



        }
    }
}
