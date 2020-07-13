using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45._2.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combo device print: " +doc); 
        }


        public void Print(string document)
        {
            Console.WriteLine("Combodevice processing: " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result!"; 
        }
    }
}
