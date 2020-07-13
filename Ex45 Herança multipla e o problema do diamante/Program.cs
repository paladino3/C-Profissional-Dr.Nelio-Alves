using Ex45.Devices;
using System;

namespace Ex45
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = 2080 };
            printer.ProcessDoc("Teste");
            printer.Print("Teste");


            Scanner scanner = new Scanner() { SerialNumber = 2070 };
            scanner.ProcessDoc("My email");

            Console.WriteLine(scanner.Scan());
        }
    }
}
