using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write("Please enter a 1-6 roll (if it's not 6, I don't know what to do for you):");
            int humanRoll = int.Parse(Console.ReadLine());
            return humanRoll;
        }

    }
}