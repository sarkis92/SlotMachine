using SlotMachine.Exceptions;
using SlotMachine.Interfaces;
using System;

namespace SlotMachine
{
    public class IODeviceManager : IIODeviceManager
    {
        public decimal MakeDeposit()
        {
            if (!this.ReadAmount(out decimal deposit))
            {
                throw new InvalidDepositException("Invalid Deposit.");
            }

            return deposit;
        }

        public decimal PlaceBet()
        {
            if (!ReadAmount(out decimal bet))
            {
                throw new InvalidBetException("Invalid Bet.");
            }

            return bet;
        }

        private bool ReadAmount(out decimal deposit)
        {
            return decimal.TryParse(Console.ReadLine(), out deposit);
        }
    }
}