using System;

namespace WebTask2.Exceptions
{
    public class MiddleNotFound : Exception
    {
        public MiddleNotFound(string message) : base(message)
        {
        }
    }
}
