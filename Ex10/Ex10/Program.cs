using System;
using System.Globalization;

namespace Ex10
{
    class Program
    {

       //static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: "+ Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
/*
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

       static double Volume(double r)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(r, 3.0);
        }
        */
    }
}
