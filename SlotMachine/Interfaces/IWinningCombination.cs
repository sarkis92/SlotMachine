namespace SlotMachine.Interfaces
{
    public interface IWinningCombination
    {
        decimal CalculateWinAmount(ISlotElementsMatrix slotElementsMatrix, decimal bet);
    }
}