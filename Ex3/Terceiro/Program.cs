using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite algo no console");
            string frase = Console.ReadLine();
            Console.WriteLine("voce digitou: "+frase);


            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine(frase);
            Console.WriteLine(vetor);//vetor String[]
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
