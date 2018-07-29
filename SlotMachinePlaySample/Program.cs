using SlotMachine;
using SlotMachine.Interfaces;
using SlotMachine.Models;
using System.Collections.Generic;

namespace SlotMachinePlaySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var winningCombinations = new List<IWinningCombination>() { new HorizontalWinCombination() };
            var slotMatrix = new ElementsMatrix(4, 3);
            var slotMachine = new Game(
                new Spinner(
                    slotMatrix,
                    new RandomElementPicker(
                        new List<SlotElement>
                        {
                            new SlotElement('A', 0.4, 0.45),
                            new SlotElement('B', 0.6, 0.35),
                            new SlotElement('P', 0.8, 0.15),
                            new SlotElement('*', 0, 0.05)
                        }),
                    new WinCalculator(winningCombinations)),
                new UserInterface(slotMatrix),
                new Player(), new AmountValidator());

            slotMachine.Play();
        }
    }
}
