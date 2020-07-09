using System;
using System.IO;

namespace Ex37
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\file1.txt";
            string targetPath = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred! " + e.Message);
            }
        }
    }
}
