using System;
using System.Collections.Generic;
using System.Text;

namespace Ex48.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> lista) where T : IComparable
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("A lista nao pode ser vazia");
            }

            T max = lista[0]; // primeiro elemento da lista
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].CompareTo(max) > 0)
                {
                    max = lista[i];
                }
            }
            return max;
        }
    }
}
