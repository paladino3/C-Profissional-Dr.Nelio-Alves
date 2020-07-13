using System;
using System.Collections.Generic;
using System.Text;

namespace Ex45.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document); // metodo Abstrado, logo a classe tem que ser abstrata
    }
}
