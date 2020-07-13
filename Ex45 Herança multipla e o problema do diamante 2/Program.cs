using Ex45._2.Entities;
using System;

namespace Ex45._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer() { SerialNumber = 1080 };
            printer.ProcessDoc("teste 1");
            printer.Print("teste 1");



            Scanner scanner = new Scanner() { SerialNumber = 2080 };
            scanner.ProcessDoc("teste 2 ");
            Console.WriteLine(scanner.Scan());


            ComboDevice cbDevice = new ComboDevice() { SerialNumber = 3080 };
            cbDevice.ProcessDoc("muito loko");
            cbDevice.Print("lokura");
            Console.WriteLine(cbDevice.Scan());
        }
    }
}
