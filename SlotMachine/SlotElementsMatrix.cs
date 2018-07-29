using SlotMachine.Interfaces;
using SlotMachine.Models;

namespace SlotMachine
{
    public class SlotElementsMatrix : ISlotElementsMatrix
    {
        private const int _rows = 4;
        private const int _cols = 3;

        public int Rows => _rows;

        public int Columns => _cols;

        public SlotElement[,] Slots { get; }

        public SlotElementsMatrix()
        {
            this.Slots = new SlotElement[_rows, _cols];
        }
    }
}
