using System;

namespace ShootingDice
{
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        public override int Roll()
        {
            Console.WriteLine($"{Name} says: You are going down!");
            return new Random().Next(DiceSize) + 1;
        }
    }
}