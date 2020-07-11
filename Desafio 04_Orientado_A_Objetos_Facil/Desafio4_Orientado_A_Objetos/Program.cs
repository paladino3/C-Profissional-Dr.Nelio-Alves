using System;
using System.Globalization;

namespace Desafio4_Orientado_A_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Funcionario func = new Funcionario();

             Console.Write("Nome: ");
             func.Nome = Console.ReadLine();
             Console.Write("Salário bruto: ");
             func.SalarioBruto = double.Parse(Console.ReadLine());
             Console.Write("Imposto: ");
             func.Imposto = double.Parse(Console.ReadLine());

             func.AtualizarDados();

             Console.Write("\nDigite a porcentagem para aumentar o salário: ");
             double valor = double.Parse(Console.ReadLine());
             func.AumentarSalario(valor);

             func.AtualizarDados();
             */

            /*   Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
            aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
            problema.
            */

            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            aluno.Resultado(n1,n2,n3);

            if (aluno.Nota >= 60.00 && aluno.Nota <= 100.00)
            {
                Console.WriteLine("NOTA FINAL = " + aluno.Nota.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + aluno.Nota);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS" , (60 - aluno.Nota).ToString("F2", CultureInfo.InvariantCulture));

            }




        }
    }
}
        

