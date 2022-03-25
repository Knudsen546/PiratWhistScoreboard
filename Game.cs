using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratVestScoreboard
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
            if(round < 8)
            {
                return (8 - round);
            }
            else {
                return (round - 6);
            }
        }
        public bool GameEnded(int round)
        {
            if(round > 13)
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
