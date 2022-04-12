using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratWhistScoreboard
{
    public class Player
    {
        public string Name { get; set; }
        public int Guess { get; set; }
        public int Score { get; set; }
        public int Zeros { get; set; }
        public Player(string firstName, int zeros)
        {
            Name = firstName;
            Score = 0;
            Zeros = zeros;
        }

        public void UpdateScore(int Guess, int Points)
        {
            if(Guess == Points)
            {
                Score += (3 + Points);
            }
            else
            {
                Score -= Math.Abs(Guess - Points);
            }
        }
    }
}
