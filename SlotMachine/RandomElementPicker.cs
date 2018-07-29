using SlotMachine.Interfaces;
using SlotMachine.Models;
using System;
using System.Collections.Generic;

namespace SlotMachine
{
    public class RandomElementPicker : IRandomElementPicker
    {
        private readonly IList<SlotElement> slotElements;
        private readonly Random random;

        public RandomElementPicker(IList<SlotElement> slotElements)
        {
            this.slotElements = slotElements;
            this.random = new Random();
        }

        public SlotElement Next()
        {
            SlotElement selected = null;

            double diceRoll = this.random.NextDouble();

            double cumulative = 0;
            for (int i = 0; i < this.slotElements.Count; i++)
            {
                cumulative += this.slotElements[i].Probability;
                if (diceRoll < cumulative)
                {
                    selected = this.slotElements[i];
                    break;
                }
            }

            return selected;
        }
    }
}
