using SlotMachine.Exceptions;
using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class AmountValidator : IAmountValidator
    {
        public void ValidateBet(decimal deposit, decimal bet)
        {
            if (bet <= 0)
            {
                throw new InvalidBetException("You need to place a bet higher than 0.");
            }
            else if (bet > deposit)
            {
                throw new InvalidBetException("You need to place a bet lower than the available deposit.");
            }
        }

        public void ValidateDeposit(decimal deposit)
        {
            if (deposit <= 0)
            {
                throw new InvalidDepositException("You need to enter a deposit higher than 0.");
            }
        }
    }
}
