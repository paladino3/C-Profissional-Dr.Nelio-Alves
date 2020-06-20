using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //conceitos basicos de casting


            int a = 5;
            int b = 2;

            //casting 
            double resultado = a / b; // 2
            Console.WriteLine(resultado);

            //fazendo o casting
            double resultado2 = (double) a / b;
            Console.WriteLine(resultado2);//2.5
        }
    }
}
