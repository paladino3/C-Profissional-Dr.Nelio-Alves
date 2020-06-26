using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetor = new string[] { "Alex","Bianca", "Renato", "Lisa", "Isabela" };



            for (int i =0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("--------------------------------------");


            // percorrer um objeto e mandar listar eles em vetor
            foreach (string objeto in vetor)
            {
                Console.WriteLine(objeto);
            }
        }
    }
}
