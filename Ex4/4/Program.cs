using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);


            Console.WriteLine("digite: nome, sexo, idade, altura");

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

      
        }                         
    }                             
}                                 
                                  