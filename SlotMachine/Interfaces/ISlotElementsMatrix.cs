using SlotMachine.Models;

namespace SlotMachine.Interfaces
{
    public interface ISlotElementsMatrix
    {
        SlotElement[,] Slots { get; }
        int Rows { get; }
        int Columns { get; }
    }
}