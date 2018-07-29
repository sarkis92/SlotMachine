using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class Game : IGame
    {
        private readonly IPlayer player;
        private readonly ISpin spinner;
        private readonly IUserInterface userInterface;
        private readonly IAmountValidator amountValidator;

        public Game(
            ISpin spinner, IUserInterface userInterface, IPlayer player, IAmountValidator amountValidator)
        {
            this.player = player;
            this.spinner = spinner;
            this.amountValidator = amountValidator;
            this.userInterface = userInterface;
        }

        public void Play()
        {
            this.MakeDeposit();

            while (this.player.Deposit > 0)
            {
                decimal winAmount = this.spinner.Spin(this.PlaceBet());

                this.player.Deposit += winAmount;

                this.userInterface.DrawScreen(winAmount, this.player.Deposit);
            }
        }

        private void MakeDeposit()
        {
            decimal deposit = this.userInterface.MakeDeposit();

            this.amountValidator.ValidateDeposit(deposit);
            this.player.Deposit = deposit;
        }

        private decimal PlaceBet()
        {
            decimal bet = this.userInterface.PlaceBet();

            this.amountValidator.ValidateBet(this.player.Deposit, bet);

            this.player.Deposit -= bet;
            return bet;
        }
    }
}
