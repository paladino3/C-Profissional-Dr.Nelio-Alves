using System;
using System.Globalization;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double CachorroQuente = 4.00;
            double X_Salada = 4.50;
            double X_bacon = 5.00;
            double TorradaSimples = 2.00;
            double Refrigerante = 1.50;

            Console.WriteLine("Codigo         Especificacao         Preco ");
            Console.WriteLine("   1           Cachorro Quente       R$4.00");
            Console.WriteLine("   2           X-Salada              R$4.50");
            Console.WriteLine("   3           X-bacon               R$5.00");
            Console.WriteLine("   4           Torrada Simples       R$2.00");
            Console.WriteLine("   5           Refrigerante          R$1.50");

            double valor1 = 0.0;
            double valor2 = 0.0;

            Console.Write("Faca seu pedido: (mesma linha) ");

            string[] vetor = Console.ReadLine().Split(' ');
            int pedido1 = int.Parse(vetor[0]);
            int pedido2 = int.Parse(vetor[1]);

            if (pedido1 == 1 && pedido2 == 1)
            {
                valor1 += 4;
                valor2 += 4;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 1 && pedido2 == 2)
            {
                valor1 += 4;
                valor2 += 4.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 1 && pedido2 == 3)
            {
                valor1 += 4;
                valor2 += 5.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 1 && pedido2 == 4)
            {
                valor1 += 4;
                valor2 += 2.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 1 && pedido2 == 5)
            {
                valor1 += 4;
                valor2 += 1.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }


            if (pedido1 == 2 && pedido2 == 1)
            {
                valor1 += 4.50;
                valor2 += 4;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 2 && pedido2 == 2)
            {
                valor1 += 4.50;
                valor2 += 4.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 2 && pedido2 == 3)
            {
                valor1 += 4.50;
                valor2 += 5.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 2 && pedido2 == 4)
            {
                valor1 += 4.50;
                valor2 += 2.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 2 && pedido2 == 5)
            {
                valor1 += 4.50;
                valor2 += 1.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }

            if (pedido1 == 3 && pedido2 == 1)
            {
                valor1 += 5.00;
                valor2 += 4;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 3 && pedido2 == 2)
            {
                valor1 += 5.00;
                valor2 += 4.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 3 && pedido2 == 3)
            {
                valor1 += 5.00;
                valor2 += 5.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 3 && pedido2 == 4)
            {
                valor1 += 5.00;
                valor2 += 2.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 3 && pedido2 == 5)
            {
                valor1 += 5.00;
                valor2 += 1.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }

            if (pedido1 == 4 && pedido2 == 1)
            {
                valor1 += 2.00;
                valor2 += 4;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 4 && pedido2 == 2)
            {
                valor1 += 2.00;
                valor2 += 4.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 4 && pedido2 == 3)
            {
                valor1 += 2.00;
                valor2 += 5.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 4 && pedido2 == 4)
            {
                valor1 += 2.00;
                valor2 += 2.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 4 && pedido2 == 5)
            {
                valor1 += 2.00;
                valor2 += 1.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }

            if (pedido1 == 5 && pedido2 == 1)
            {
                valor1 += 1.50;
                valor2 += 4;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 5 && pedido2 == 2)
            {
                valor1 += 1.50;
                valor2 += 4.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 5 && pedido2 == 3)
            {
                valor1 += 1.50; ;
                valor2 += 5.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 5 && pedido2 == 4)
            {
                valor1 += 1.50;
                valor2 += 2.00;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }
            else if (pedido1 == 5 && pedido2 == 5)
            {
                valor1 += 1.50;
                valor2 += 1.50;
                Console.WriteLine("total e: {0} reais", valor1 + valor2);
            }

        }
    }
}
