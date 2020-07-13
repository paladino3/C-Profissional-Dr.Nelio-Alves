using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45.Devices
{
    class Printer : Device
    {

        public void Print(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }
    }
}
