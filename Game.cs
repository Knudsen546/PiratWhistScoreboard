using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratWhistScoreboard
{
    public class Game
    {
        public int Round { get; set; }
        public int numberOfPlayers;
        
        public Game(int players, int round)
        {
            numberOfPlayers = players;
            Round = round;
        }
        public int NumberOfCards(int round)
        {
            if(round < 7)
            {
                return (7 - round);
            }
            else
            {
                return (round - 5);
            }
        }
        public bool GameEnded(int round)
        {
            if(round > 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
