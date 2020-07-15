using System;
using System.Collections.Generic;
using System.IO;

namespace Ex46
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 14 Interfaces\Interface_IComparable\ex1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();

                    while (!sr.EndOfStream) // enquanto nao acabar os textos
                    {
                        list.Add(sr.ReadLine()); // o loop percorre as string, lendo e armazenando na lista
                    }
                    list.Sort(); // ordernar em ordem alfabetica
                    foreach (string text in list)
                    {
                        Console.WriteLine(text.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }

        }
    }
}
