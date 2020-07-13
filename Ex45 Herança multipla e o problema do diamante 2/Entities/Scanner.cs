using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45._2.Entities
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }

        public string Scan()
        {
            return "Scanner sacn result: ";
        }
    }
}
