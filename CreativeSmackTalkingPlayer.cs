using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts = new List<string>()
        {
            "You're bad at dice!",
            "You'll never beat my roll!",
            "You should've just taken out the trash!"
        };

        public override int Roll()
        {
            int rollValue = new Random().Next(DiceSize) + 1;
            string selectedTaunt = Taunts[new Random().Next(0, Taunts.Count + 1)];
            Console.WriteLine(selectedTaunt);
            return rollValue;
        }
    }
}