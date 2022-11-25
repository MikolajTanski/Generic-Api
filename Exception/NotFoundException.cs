using System;

namespace zadanie.Exception
{
    public class NotFoundException : SystemException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}

