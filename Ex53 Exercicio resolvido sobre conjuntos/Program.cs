using Ex53.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ex53
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\seçao 15 Generics, Set, Dictionary\arquivos\in.txt



            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { UserName = name, Instant = instant }); // instanciando um LogRecord, dentro da lista HASHSET (conjunto)
                    }
                    Console.WriteLine("Total users: " + set.Count); //quantidade de elementos do meu conjunto
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
