using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8_Orientado_a_Objetos
{
    class Triangulo
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }



        public double Raiz()
        {
            double p = (A + B + C) / 2.00;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }

    }
}
