using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*      Console.Write("Digite a senha: ");
                  int x = int.Parse(Console.ReadLine());
                  while ( x != 2002)
                  {
                      Console.WriteLine("Senha Invalida");
                      Console.Write("Digite a senha: ");
                      x = int.Parse(Console.ReadLine());
                  }
                      Console.WriteLine("Acesso Permitido"); */

            int a = 0;
            int g = 0;
            int d = 0;

            Console.WriteLine("Digite o numero do combustivel");
            int x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    a++;
                }
                else if (x == 2)
                {
                    g++;
                }
                else if (x == 3)
                {
                    d++;
                }

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: "+ g);
            Console.WriteLine("Diesel: " + d);
        }
    }
}
