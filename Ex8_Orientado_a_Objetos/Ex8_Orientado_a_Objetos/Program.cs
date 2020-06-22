using System;
using System.Globalization;
namespace Ex8_Orientado_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; // declarando uma variavel de uma classe 

            x = new Triangulo(); // instanciando os objetos
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*
                        double p = (x.A + x.B + x.C) / 2.0;
                        double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

                        p = (y.A + y.B + y.C) / 2.0;
                        double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            */
            double areaX = x.Raiz();
            double areaY = y.Raiz();


            Console.WriteLine("Area de X: "+areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: "+areaY.ToString("F4", CultureInfo.InvariantCulture));
            if(areaX > areaY)
            {
                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area Y");
            }
        }
    }
}
