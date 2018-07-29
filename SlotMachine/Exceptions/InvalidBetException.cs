using System;

namespace SlotMachine.Exceptions
{
    public class InvalidBetException : Exception
    {
        public InvalidBetException(string message) : base(message)
        {
        }
    }
}
