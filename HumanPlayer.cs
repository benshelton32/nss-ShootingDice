using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write("Please enter a number for your roll (1-6):");
            int playerRoll = int.Parse(Console.ReadLine());
            return playerRoll;
        }
    }
}