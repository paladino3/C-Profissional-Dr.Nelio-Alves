using System;
using System.Globalization;

namespace Ex11_Orientado_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio de fixacao para menbros estaticos*/
            
                        Console.Write("Qual é a cotação do dólar de hoje? ");
                        double cotacao = double.Parse(Console.ReadLine());


                        Console.Write("Quantos dolares eu vou comprar? ");
                        double qtde = double.Parse(Console.ReadLine());

                        Conversor.Converter(cotacao, qtde);

                        Console.Write("Valor a ser pago em Reais =  " + Conversor.resultado.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
