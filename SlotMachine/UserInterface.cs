using SlotMachine.Exceptions;
using SlotMachine.Interfaces;
using System;

namespace SlotMachine
{
    public class UserInterface : IUserInterface
    {
        private readonly IElementsMatrix machineSlots;

        public UserInterface(IElementsMatrix machineSlots)
        {
            this.machineSlots = machineSlots;
        }

        public void DrawScreen(decimal winAmount, decimal balance)
        {
            for (int row = 0; row < this.machineSlots.Rows; row++)
            {
                for (int col = 0; col < this.machineSlots.Columns; col++)
                {
                    Console.Write(this.machineSlots.Slots[row, col].Symbol);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"You have won: {winAmount:F1}");
            Console.WriteLine($"Current balance is: {balance:F1}");
        }

        public decimal MakeDeposit()
        {
            Console.WriteLine("Place deposit money you would like to play with:");
            if (!this.ReadAmount(out decimal deposit))
            {
                throw new InvalidDepositException("Invalid Deposit.");
            }

            return deposit;
        }

        public decimal PlaceBet()
        {
            Console.WriteLine("Enter stake amount:");
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
