using System;
using System.Collections.Generic;
using System.IO;

namespace D14
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\seçao 15 Generics, Set, Dictionary\arquivos\Canditatos.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> candidate = new Dictionary<string, int>();
                    //List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        string[] vector = sr.ReadLine().Split(',');
                        string name = vector[0];
                        int votes = int.Parse(vector[1]);
/*

                        try
                        {
                            candidate[name] += votes;
                        }
                        catch
                        {
                            candidate[name] = votes;
                        }

                    */

                        if (candidate.ContainsKey(name))
                        {
                            //Dictionary[chave] =  valor
                            candidate[name] += votes;
                        }
                        else
                        {
                            //Dictionary[chave] =  valor
                            candidate[name] = votes;
                        }


                    }
                    foreach (KeyValuePair<string, int> e in candidate)
                    {
                        Console.WriteLine("Candidate: " + e.Key + ", Number of Votes: " + e.Value);
                    }
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
