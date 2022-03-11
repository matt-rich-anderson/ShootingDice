using System;

namespace ShootingDice
{
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        public override int Roll()
        {
            Console.WriteLine("You are going down!");
            return new Random().Next(DiceSize) + 1;
        }
    }
}