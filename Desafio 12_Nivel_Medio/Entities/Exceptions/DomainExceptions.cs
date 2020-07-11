using System;
using System.Collections.Generic;
using System.Text;

namespace D12.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
