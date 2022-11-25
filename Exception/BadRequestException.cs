using System;

namespace zadanie.Exception
{
    public class BadRequestException : SystemException
    {
        public BadRequestException(string message) : base(message)
        {

        }
    }
}



