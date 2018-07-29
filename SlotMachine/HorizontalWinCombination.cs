using SlotMachine.Interfaces;
using SlotMachine.Models;
using System;

namespace SlotMachine
{
    public class HorizontalWinCombination : IWinningCombination
    {
        private const char _wildcard = '*';

        public decimal CalculateWinAmount(ISlotElementsMatrix matrix, decimal bet)
        {
            decimal winAmount = 0;

            for (int row = 0; row < matrix.Rows; row++)
            {
                int startColIdx = 0;
                SlotElement comparingElement = null;

                //Get first non wildcard element and its position
                while (startColIdx < matrix.Columns)
                {
                    if (matrix.Slots[row, startColIdx].Mark != _wildcard)
                    {
                        comparingElement = matrix.Slots[row, startColIdx];
                        break;
                    }
                    startColIdx++;
                }

                // Iterate to the end of the row to see if all elements are the same
                // and to sum up their coeficient.
                double coeficientSum = comparingElement?.Coeficient ?? 0;
                bool winningLine = true;
                for (int col = startColIdx + 1; col < matrix.Columns; col++)
                {
                    SlotElement current = matrix.Slots[row, col];

                    if (comparingElement.Mark != current.Mark &&
                        current.Mark != _wildcard)
                    {
                        winningLine = false;
                        break;
                    }
                    coeficientSum += current.Coeficient;
                }

                if (winningLine)
                {
                    winAmount += (decimal)coeficientSum * bet;
                }
            }

            return Math.Round(winAmount, 1);
        }
    }
}
