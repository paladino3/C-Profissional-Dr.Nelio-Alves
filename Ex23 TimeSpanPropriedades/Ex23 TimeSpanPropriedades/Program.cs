using System;

namespace Ex23_TimeSpanPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        TimeSpan t1 = TimeSpan.MaxValue;
                        TimeSpan t2 = TimeSpan.MinValue;
                        TimeSpan t3 = TimeSpan.Zero;

                        Console.WriteLine(t1);
                        Console.WriteLine(t2);
                        Console.WriteLine(t3);
            */

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 05);

            TimeSpan soma = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t1.Multiply(2.0);
            TimeSpan divide = t1.Divide(2.0);

            Console.WriteLine("Soma de " + t1 + " + " + t2 + " = " + soma);
            Console.WriteLine("Diferenca de " + t1 + " - " + t2 + " = " + dif);
            Console.WriteLine("O valor de " + t1 + " x2 = " + mult);
            Console.WriteLine("O valor de " + t1 + " /2 = " + divide);




        }
    }
}
