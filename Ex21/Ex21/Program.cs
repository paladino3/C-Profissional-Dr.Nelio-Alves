using System;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TimeSpan");
            /*
                        TimeSpan t1 = new TimeSpan(0, 1, 20);
                        TimeSpan t2 = new TimeSpan(800000000L);
                        TimeSpan t3 = new TimeSpan(2, 11, 20);
                        TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
                        TimeSpan t5 = new TimeSpan(1, 3, 5, 24, 052);

                        Console.WriteLine(t1);
                        Console.WriteLine(t1.Ticks);
                        Console.WriteLine(t2);
                        Console.WriteLine(t3);
                        Console.WriteLine(t4);
                        Console.WriteLine(t5);
            */


            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(800000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
