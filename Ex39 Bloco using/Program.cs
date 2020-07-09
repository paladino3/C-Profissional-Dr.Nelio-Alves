using System;
using System.IO;
using System.Linq.Expressions;

namespace Ex39_Bloco_using
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\filexx.txt";

                //usando o Using, nao precisa fechar a aplicacao manualmente, o comando using fecha automaticamente

                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open)) ;

                    using (StreamReader sr = new StreamReader(path))
                    {

                        string line = sr.ReadToEnd();
                        Console.WriteLine(line);
                    }

                }
                catch (IOException e)
                {
                    Console.WriteLine("Um erro ocorreu!");
                    Console.WriteLine(e.Message);
                }
                */


           //*Maneira eficaz, e  enxuta de ler um arquivo! usando USING

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\file1.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string lines = streamReader.ReadToEnd();
                    Console.WriteLine(lines);
                }
            }catch (IOException e)
            {
                Console.WriteLine("Un error ocorred. ");
                Console.WriteLine(e.Message);
            }


        }
    }
}
