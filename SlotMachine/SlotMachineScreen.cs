using SlotMachine.Interfaces;
using System;

namespace SlotMachine
{
    public class SlotMachineScreen : IUserInterface
    {
        private readonly ISlotElementsMatrix machineSlots;

        public SlotMachineScreen(ISlotElementsMatrix machineSlots)
        {
            this.machineSlots = machineSlots;
        }

        public void DrawScreen(decimal winAmount, decimal balance)
        {
            for (int row = 0; row < this.machineSlots.Rows; row++)
            {
                for (int col = 0; col < this.machineSlots.Columns; col++)
                {
                    Console.Write(this.machineSlots.Slots[row, col].Mark);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"You have won: {winAmount:F1}");
            Console.WriteLine($"Current balance is: {balance:F1}");
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
