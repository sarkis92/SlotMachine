namespace SlotMachine.Interfaces
{
    public interface IWinCalculator
    {
        decimal Calculate(ISlotElementsMatrix slotElementsMatrix, decimal bet);
    }
}