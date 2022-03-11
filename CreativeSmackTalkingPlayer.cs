using System;
using System.Collections.Generic;

namespace ShootingDice

{
    public class CreativeSmackTalkingPlayer : Player
    {
    
        public override int Roll()
        {
            var taunts = new List<string>
                {   
                    "It's time to bring out the big guns!", 
                    "Daddy needs a new pair of shoes!",
                    "Common, moneymoneymoney!",
                };
            
            string selectedTaunt = taunts[new Random().Next(3) + 1];
            
            Console.WriteLine(selectedTaunt);
            return new Random().Next(DiceSize) + 1;
        }
    
    }
}