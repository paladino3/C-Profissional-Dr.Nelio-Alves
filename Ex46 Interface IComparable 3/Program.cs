using ordernar.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ordernar
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 14 Interfaces\Interface_IComparable\func.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach(Funcionario func in list)
                    {
                        Console.WriteLine(func);
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
