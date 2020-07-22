using Ex58.Services;
using System;

namespace Ex58
{
    delegate double TesteCalculos(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            TesteCalculos sum = CalculationServices.Sum;
            TesteCalculos max = CalculationServices.Max;
           // TesteCalculos square = CalculationServices.Square;

            
            double result = sum.Invoke(a, b);
            double result1 = max(a, b);
            //double result2 = square(a); //da erro porque o delagate espera dois parametros

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
