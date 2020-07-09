using System;
using System.IO;

namespace Ex40
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\file1.txt";
            string targetPath = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocorred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
