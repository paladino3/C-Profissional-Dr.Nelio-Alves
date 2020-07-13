using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45._2.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc); // metodo Abstrato logo requer que a classe seja abstrata


    }
}
