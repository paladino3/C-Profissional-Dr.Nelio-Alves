using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {

            /* DateTime d1 = DateTime.Now;
             Console.WriteLine(d1);
             Console.WriteLine(d1.Ticks);*/
            /*
                        DateTime d2 = new DateTime(2020, 06, 30);
                        DateTime d3 = new DateTime(2020, 06, 30, 20, 11, 55);
                        DateTime d4 = new DateTime(2020, 06, 30, 20, 11, 55, 300);

                        DateTime d5 = DateTime.Now;
                        DateTime d6 = DateTime.UtcNow;
                        DateTime d7 = DateTime.Today;

                        Console.WriteLine(d2);
                        Console.WriteLine(d3);
                        Console.WriteLine(d4);


                        Console.WriteLine("_________________________");
                        Console.WriteLine(d5);
                        Console.WriteLine(d6);
                        Console.WriteLine(d7); 
                        */

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d10 = DateTime.Parse("2000-08-15 13:05:52");
            DateTime d2 = DateTime.Parse("06/30/2020");
            DateTime d3 = DateTime.Parse("08/15/2000");


            DateTime d4 = DateTime.ParseExact("15-08-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime d5 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d10);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
        }
    }
}
