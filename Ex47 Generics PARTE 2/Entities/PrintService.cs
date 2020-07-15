using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ex47.Entities
{
    class PrintService<T>
    {

        T[] _vetor = new T[10];

        int _tam = 0;

        public void AddValue(T value)
        {
            if (_tam == 10)
            {
                throw new Exception("O tamanho do array esta cheio");
            }
            _vetor[_tam] = value;
            _tam++;
        }

        public T First()
        {
            return _vetor[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _tam - 1; i++)
            {
                Console.Write(_vetor[i] + ", ");
            }
            if(_tam > 0)
            {
                Console.Write(_vetor[_tam -1 ]);
            }
            Console.WriteLine("]");
        }


    }
}
