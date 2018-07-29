namespace SlotMachine.Interfaces
{
    public interface IWinningCombination
    {
        decimal CalculateWinAmount(IElementsMatrix slotElementsMatrix, decimal bet);
    }
}