namespace SlotMachine.Interfaces
{
    public interface IUserInterface
    {
        void DrawScreen(decimal winAmount, decimal balance);
        void Message(string message);
    }
}