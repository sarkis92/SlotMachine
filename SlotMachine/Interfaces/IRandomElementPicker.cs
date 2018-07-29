using SlotMachine.Models;

namespace SlotMachine.Interfaces
{
    public interface IRandomElementPicker
    {
        SlotElement Next();
    }
}