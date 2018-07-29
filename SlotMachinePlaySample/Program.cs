using SlotMachine;
using SlotMachine.Interfaces;
using SlotMachine.Models;
using System;
using System.Collections.Generic;

namespace SlotMachinePlaySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var slotElements = new List<SlotElement> { new Banana(), new Apple(), new Pineapple(), new Wildcard() };
            var winningCombinations = new List<IWinningCombination>() { new HorizontalWinCombination() };
            var slotMatrix = new SlotElementsMatrix();
            var slotMachine = new SlotMachineGame(
                new SlotMachineSpinner(
                    slotMatrix,
                    new RandomElementPicker(slotElements),
                    new WinCalculator(winningCombinations)),
                new UserInterfaceMediator(new SlotMachineScreen(slotMatrix), new IODeviceManager()),
                new Player(), new AmountValidator());

            slotMachine.Play();
        }
    }
}
