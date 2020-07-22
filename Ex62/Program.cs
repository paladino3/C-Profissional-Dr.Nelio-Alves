using System;
using System.Linq;

namespace Ex62
{
    class Program
    {
        static void Main(string[] args)
        {

            //Specify the data source(Especificar o banco de dados)

            int[] numbers = new int[] { 2, 3, 4, 5 };


            //Define the query expression (Defenir a expressao da consulta)

            //where ela filtra a colecao de dados
            var result = numbers.Where(x => x % 2 == 0)
                
                .Select(x => x * 10); // outra funcao que pega o resultado e multiplica por 10


            //Execute the query   (Executar a consulta)

            foreach(int res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
