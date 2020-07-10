using Ex43.Entities;
using System;
using System.Globalization;

namespace Ex43
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Aluguel de carros dados");
                Console.Write("Modelo do carro: ");
                string modelo = Console.ReadLine();
                Console.Write("Data de retirada (dd/mm/yyyy hh:ss): ");
                DateTime retirada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de devolucao (dd/mm/yyyy hh:ss): ");
                DateTime devolucao = DateTime.Parse(Console.ReadLine());
                Console.Write("Entre com o preco por hora: ");
                double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com o preco por dia: ");
                double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Locadora locadora = new Locadora(modelo, retirada, devolucao, precoHora, precoDia);

                locadora.Duracao(retirada, devolucao, precoHora, precoDia);


            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na digitacao");
                Console.WriteLine(e.Message);
            }

        }
    }
}
