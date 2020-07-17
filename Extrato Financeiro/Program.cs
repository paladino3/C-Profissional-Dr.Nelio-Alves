using Extrato.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Numerics;

namespace Extrato
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\Seçao 14 Interfaces\extratoUnopar\parcelas.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Parcela> listParcela = new List<Parcela>();

                    while (!sr.EndOfStream)
                    {
                        listParcela.Add(new Parcela(sr.ReadLine()));
                    }

                    double total = 0;
                    foreach (Parcela e in listParcela)
                    {
                        if (!string.IsNullOrEmpty(e.ToString()))
                        {
                            Console.WriteLine(e.ToString(), CultureInfo.InvariantCulture);
                            total += e.Valor;
                        }
                    }
                    Console.WriteLine("Total do curso: " + total.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocurreu!" + e.Message);
            }

        }
    }
}
