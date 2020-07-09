using System;


namespace Ex36.Entities.Exceptions
{
    class DomainException : ApplicationException
    {


        public DomainException(string message) : base(message)
        {
        }


    }
}
