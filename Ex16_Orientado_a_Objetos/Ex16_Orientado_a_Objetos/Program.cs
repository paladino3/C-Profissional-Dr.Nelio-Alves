using System;

namespace Ex16_Orientado_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(3, 4);
            int s2 = Calculadora.Soma(3, 4, 74, 4554, 0);
            int s3 = Calculadora.Soma(3, 4, 47, 4, 44, 1, 74);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
