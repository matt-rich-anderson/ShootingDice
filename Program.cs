using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new SmackTalkingPlayer();
            player2.Name = "Sue";

            player1.Play(player2);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Tim";

            Player player4 = new OneHigherPlayer();
            player4.Name = "Eric";

            player4.Play(player3);

            Console.WriteLine("-------------------");
            Player player5 = new Player();
            player5.Name = "Jacob";

            Player player6 = new HumanPlayer();
            player6.Name = "Matt";

            player6.Play(player5);

            Console.WriteLine("-------------------");
            
            Player player7 = new Player();
            player7.Name = "Jim";

            Player player8 = new CreativeSmackTalkingPlayer();
            player8.Name = "Derreck";

            player8.Play(player7);

            Console.WriteLine("-------------------");

            Player player9 = new Player();
            player9.Name = "Bryce";

            Player player10 = new SoreLoserPlayer();
            player10.Name = "Hunter";

            player10.Play(player9);

            Console.WriteLine("-------------------");

            Player player11 = new Player();
            player11.Name = "Joker";

            Player player12 = new UpperHalfPlayer();
            player12.Name = "Riddler";

            player12.Play(player11);

            Console.WriteLine("-------------------");

            Player player13 = new Player();
            player13.Name = "Jack Burton";

            Player player14 = new SoreLoserUpperHalfPlayer();
            player14.Name = "Lo Pan";

            player14.Play(player13);

            Console.WriteLine("-------------------");
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}