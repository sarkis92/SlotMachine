using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class UserInterfaceMediator : IUserInterfaceController
    {
        private readonly IUserInterface userInterface;
        private readonly IIODeviceManager ioDeviceManager;

        public UserInterfaceMediator(IUserInterface userInterface, IIODeviceManager ioDeviceManager)
        {
            this.userInterface = userInterface;
            this.ioDeviceManager = ioDeviceManager;
        }

        public void DrawScreen(decimal winAmount, decimal deposit)
        {
            this.userInterface.DrawScreen(winAmount, deposit);
        }

        public decimal MakeDeposit()
        {
            this.userInterface.Message("Place deposit money you would like to play with:");
            return this.ioDeviceManager.MakeDeposit();
        }

        public decimal PlaceBet()
        {
            this.userInterface.Message("Enter stake amount:");
            return this.ioDeviceManager.PlaceBet();
        }
    }
}
