using SlotMachine.Models;

namespace SlotMachine.Interfaces
{
    public interface IElementsMatrix
    {
        SlotElement[,] Slots { get; }
        int Rows { get; }
        int Columns { get; }
    }
}