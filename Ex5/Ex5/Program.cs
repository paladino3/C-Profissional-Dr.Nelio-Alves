using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               int n1 = int.Parse(Console.ReadLine());
               int n2 = int.Parse(Console.ReadLine());
               int n3 = int.Parse(Console.ReadLine());

               if (n1 > n2 && n1 > n3)
               {
                   Console.WriteLine("Maior = " + n1);
               }
               else if (n2 > n3)
               {
                   Console.WriteLine("Maior = " + n2);
               }
               else
               {
                   Console.WriteLine("Maior = " + n3);
               }

       */


            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior " + resultado);

        }

        static int Maior(int a, int b, int c)
        {
            int r;
            if (a > b && a > c)
            {
                r = a;
            }
            else if (b > c)
            {
                r = b;
            }
            else
            {
                r = c;
            }
            return r;
        }
    }
    }
