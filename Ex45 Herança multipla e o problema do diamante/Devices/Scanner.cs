using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45.Devices
{
    class Scanner : Device
    {
        public string Scan()
        {
            return "Scanner scan result";
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }
    }
}
