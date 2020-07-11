using System;
using System.Security.Cryptography;

namespace ex2
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
            Console.Write("Digite o seu pedido: (mesma linha): ");
            string[] pedido = Console.ReadLine().Split(' ');
            int p1 = int.Parse(pedido[0]);
            int p2 = int.Parse(pedido[1]);
           
            if (p1 == 1)
            {
                valor1 += 4.00;
            }
            else if (p1 == 2)
            {
                valor1 += 4.50;
            }
            else if (p1 == 3)
            {
                valor1 += 5.00;
            }
            else if (p1 == 4)
            {
                valor1 += 2.00;
            }
            else if (p1 == 5)
            {
                valor1 += 1.50;
            }

            if (p2 == 1)
            {
                valor2 += 4.00;
            }
            else if (p2 == 2)
            {
                valor2 += 4.50;
            }
            else if (p2 == 3)
            {
                valor2 += 5.00;
            }
            else if (p2 == 4)
            {
                valor2 += 2.00;
            }
            else if (p2 == 5)
            {
                valor2 += 1.50;
            }

            var total = valor1 + valor2;
            Console.WriteLine(total);
        }
      
    }
}
