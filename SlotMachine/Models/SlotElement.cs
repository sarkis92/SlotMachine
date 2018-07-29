namespace SlotMachine.Models
{
    public class SlotElement
    {
        public char Symbol { get; }

        public double Coeficient { get; }

        public double Probability { get; }

        public SlotElement(char symbol, double coeficient, double probability)
        {
            this.Symbol = symbol;
            this.Coeficient = coeficient;
            this.Probability = probability;
        }
    }
}