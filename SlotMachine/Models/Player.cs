using SlotMachine.Interfaces;

namespace SlotMachine.Models
{
    public class Player : IPlayer
    {
        public decimal Deposit { get; set; }
    }
}
