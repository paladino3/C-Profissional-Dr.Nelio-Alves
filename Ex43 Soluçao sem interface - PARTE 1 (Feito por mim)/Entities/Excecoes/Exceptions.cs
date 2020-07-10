using System;
using System.Collections.Generic;
using System.Text;

namespace Ex43.Entities.Excecoes
{
    class Exceptions : SystemException
    {

        public Exceptions(string message)
            : base(message)
        {
        }
    }
}
