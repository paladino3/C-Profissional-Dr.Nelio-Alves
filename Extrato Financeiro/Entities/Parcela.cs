using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Extrato.Entities
{
    class Parcela : IComparable
    {
        public double Valor { get; set; }

        public Parcela(string valor)
        {
            double d = Convert.ToDouble(valor);
            Valor = d;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Parcela))
            {
                throw new Exception("An error: Obj is not parcela");
            }

            Parcela other = obj as Parcela;
            return Valor.CompareTo(other.Valor);

        }

        public override string ToString()
        {
            return "Valor: " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
