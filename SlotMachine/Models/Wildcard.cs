namespace SlotMachine.Models
{
    public class Wildcard : SlotElement
    {
        public override char Mark => '*';

        public override double Coeficient => 0;

        public override double Probability => 0.5;
    }
}
