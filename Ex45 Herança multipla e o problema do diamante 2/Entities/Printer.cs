using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45._2.Entities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }

        public void Print(string doc)
        {
            Console.WriteLine("Printer print: " + doc);
        }
    }
}
