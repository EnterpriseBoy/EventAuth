using System;


namespace EventAuth.Exceptions
{
    public class ValidationEx : Exception
    {
        public ValidationEx()
        {
        }

        public ValidationEx(string message) :base (message)
        {
        }

        public ValidationEx(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
