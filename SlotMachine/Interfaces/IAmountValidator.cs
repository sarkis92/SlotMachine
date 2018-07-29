namespace SlotMachine.Interfaces
{
    public interface IAmountValidator
    {
        void ValidateDeposit(decimal deposit);
        void ValidateBet(decimal deposit, decimal bet);
    }
}