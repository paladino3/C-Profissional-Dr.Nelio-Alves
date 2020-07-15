using Ex47.Entities;
using System;

namespace Ex47
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Metodo Genericos*/

            //PrintService<int> print = new PrintService<int>();
            PrintService<string> print = new PrintService<string>();

            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               // int x = int.Parse(Console.ReadLine());
                string x = Console.ReadLine();
                print.AddValue(x);
            }

            print.Print();
            Console.WriteLine("Fisrt: " + print.First());
        }
    }
}
