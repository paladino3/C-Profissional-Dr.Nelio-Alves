using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce vai digitar? ");
            int x = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1;  i <= x; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int y = int.Parse(Console.ReadLine());
                soma += y; 

            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
