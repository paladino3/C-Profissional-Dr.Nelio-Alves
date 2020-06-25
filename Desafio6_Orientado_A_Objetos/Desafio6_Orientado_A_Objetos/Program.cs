using System;
using System.Numerics;

namespace Desafio6_Orientado_A_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Inn[] vector = new Inn[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent #{0}:", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vector[i] = new Inn { Name = name, Email = email, Room = room };
            }

            for (int i = 0; i < n; i++)
            {
                if (vector[i] != null)
                {
                    Console.WriteLine(vector[i].Room + ": " + vector[i].Name + ", " + vector[i].Email);
                }
            }
        }
    }
}
