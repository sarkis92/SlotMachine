namespace SlotMachine.Interfaces
{
    public interface IWinCalculator
    {
        decimal Calculate(IElementsMatrix slotElementsMatrix, decimal bet);
    }
}