using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class SlotMachineGame : IGame
    {
        private readonly IPlayer player;
        private readonly ISpin spinner;
        private readonly IUserInterfaceController userInterfaceController;
        private readonly IAmountValidator amountValidator;

        public SlotMachineGame(
            ISpin spinner, IUserInterfaceController userInterfaceController, IPlayer player, IAmountValidator amountValidator)
        {
            this.player = player;
            this.spinner = spinner;
            this.amountValidator = amountValidator;
            this.userInterfaceController = userInterfaceController;
        }

        public void Play()
        {
            this.MakeDeposit();

            while (this.player.Deposit > 0)
            {
                decimal winAmount = this.spinner.Spin(this.PlaceBet());

                this.player.Deposit += winAmount;

                this.userInterfaceController.DrawScreen(winAmount, this.player.Deposit);
            }
        }

        private void MakeDeposit()
        {
            decimal deposit = this.userInterfaceController.MakeDeposit();

            this.amountValidator.ValidateDeposit(deposit);
            this.player.Deposit = deposit;
        }

        private decimal PlaceBet()
        {
            decimal bet = this.userInterfaceController.PlaceBet();

            this.amountValidator.ValidateBet(this.player.Deposit, bet);

            this.player.Deposit -= bet;
            return bet;
        }
    }
}
