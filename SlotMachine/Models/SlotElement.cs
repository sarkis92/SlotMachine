namespace SlotMachine.Models
{
    public abstract class SlotElement
    {
        public abstract char Mark { get; }

        public abstract double Coeficient { get; }

        public abstract double Probability { get; }
    }
}