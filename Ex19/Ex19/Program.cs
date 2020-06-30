using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________Ternário________________");

            double valor = double.Parse(Console.ReadLine());
            double desconto;

            if (valor < 20.00)
            {
                desconto = valor * 0.10;
            }
            else
            {
                desconto =  valor * 0.05;
            }

            Console.WriteLine(valor);

        }
    }
}
