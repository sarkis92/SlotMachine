namespace SlotMachine.Models
{
    public class Banana : SlotElement
    {
        public override char Mark => 'B';

        public override double Coeficient => 0.6;

        public override double Probability => 0.35;
    }
}
