using SlotMachine.Interfaces;
using SlotMachine.Models;

namespace SlotMachine
{
    public class ElementsMatrix : IElementsMatrix
    {
        public int Rows { get; }

        public int Columns { get; }

        public SlotElement[,] Slots { get; }
        
        public ElementsMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Columns = cols;
            this.Slots = new SlotElement[rows, cols];
        }
    }
}
