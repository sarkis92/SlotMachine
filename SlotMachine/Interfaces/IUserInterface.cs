namespace SlotMachine.Interfaces
{
    public interface IUserInterface
    {
        decimal MakeDeposit();
        decimal PlaceBet();
        void DrawScreen(decimal winAmount, decimal deposit);
    }
}