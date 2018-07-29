using System;

namespace SlotMachine.Exceptions
{
    public class InvalidDepositException : Exception
    {
        public InvalidDepositException(string message) : base(message)
        {
        }
    }
}
