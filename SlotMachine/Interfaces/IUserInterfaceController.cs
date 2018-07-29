namespace SlotMachine.Interfaces
{
    public interface IUserInterfaceController
    {
        decimal MakeDeposit();
        decimal PlaceBet();
        void DrawScreen(decimal winAmount, decimal deposit);
    }
}