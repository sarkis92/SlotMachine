﻿using SlotMachine.Interfaces;
using System.Collections.Generic;

namespace SlotMachine
{
    public class WinCalculator : IWinCalculator
    {
        private readonly IList<IWinningCombination> winningCombinations;

        public WinCalculator(IList<IWinningCombination> winningCombinations)
        {
            this.winningCombinations = winningCombinations;
        }

        public decimal Calculate(IElementsMatrix slotElementsMatrix, decimal bet)
        {
            decimal winAmount = 0;

            foreach (var winningCombination in this.winningCombinations)
            {
                winAmount += winningCombination.CalculateWinAmount(slotElementsMatrix, bet);
            }

            return winAmount;
        }
    }
}
