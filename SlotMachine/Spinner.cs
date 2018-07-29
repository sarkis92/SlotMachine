using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class Spinner : ISpin
    {
        private readonly IElementsMatrix machineSlots;
        private readonly IRandomElementPicker randomElementPicker;
        private readonly IWinCalculator winCalculator;

        public Spinner(
            IElementsMatrix machineSlots,
            IRandomElementPicker randomElementPicker,
            IWinCalculator winCalculator)
        {
            this.machineSlots = machineSlots;
            this.randomElementPicker = randomElementPicker;
            this.winCalculator = winCalculator;
        }

        public decimal Spin(decimal bet)
        {
            for (int row = 0; row < this.machineSlots.Rows; row++)
            {
                for (int col = 0; col < this.machineSlots.Columns; col++)
                {
                    this.machineSlots.Slots[row, col] = this.randomElementPicker.Next();
                }
            }

            return this.winCalculator.Calculate(this.machineSlots, bet);
        }
    }
}