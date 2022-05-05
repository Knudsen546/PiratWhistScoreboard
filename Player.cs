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
        public int Streak { get; set; }
        public Player(string firstName, int zeros)
        {
            Name = firstName;
            Score = 0;
            Zeros = zeros;
            Streak = 0;
        }

        public void UpdateScore(int Guess, int Points)
        {
            if(Guess == Points)
            {
                Score += (3 + Points);
                Streak += 1;
            }
            else
            {
                Score -= Math.Abs(Guess - Points);
                Streak = 0;
            }
        }
    }
}
