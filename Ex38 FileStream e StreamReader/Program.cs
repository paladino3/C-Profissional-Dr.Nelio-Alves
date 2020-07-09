using System;
using System.IO;

namespace Ex38
{
    class Program
    {
        static void Main(string[] args)
        {


            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 13 Trabalhando com arquivos\file1.txt";

            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //instanciando o fileStream, passando o caminho do arquivo, e Abrindo esse arquivo
                fileStream = new FileStream(path, FileMode.Open);

                //instanciando o StreamReader, iniciando com o fileStream, associacao 
                streamReader = new StreamReader(fileStream);

                string line = streamReader.ReadToEnd();

                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu! ");
                Console.WriteLine("" + e.Message);
            }
            finally
            {
                //precisa do finally fechar esse arquivo!
                if (fileStream != null) fileStream.Close();
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}
