using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiratWhistScoreboard
{
    public partial class Form1 : Form
    {
        public List<string> textList = new List<string>();
        public List<Player> playerList = new List<Player>();
        public List<int> guessList = new List<int>();
        public List<int> guessListUpdate = new List<int>();
        public List<int> pointsList = new List<int>();
        public List<Game> gameList = new List<Game>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Start_Click(object sender, EventArgs e)
        {
            Overview.Clear();
            playerList.Clear();
            Start.Enabled = false;
            EndGame.Enabled = true;
            textList = Names.Text.Split('\n').ToList<string>();
            Names.ReadOnly = true;
            Guess.ReadOnly = false;
            Points.ReadOnly = false;
            NextRound.Enabled = true;
            gameList.Add(new Game(textList.Count, 0));
            int zeros = 6;
            foreach (string name in textList)
            {
                if (textList.Count <= 5)
                {
                    zeros = 3;
                }
                else if (textList.Count == 6)
                {
                    zeros = 4;
                }
                else if(textList.Count == 7)
                {
                    zeros = 5;
                }
                Player player = new Player(name, zeros);
                playerList.Add(player);
                NumberOfZeros.AppendText(player.Zeros + Environment.NewLine);
            }
            textBoxNumberOfCards.Text = gameList[0].NumberOfCards(gameList[0].Round).ToString();
        }

        private void NextRound_Click(object sender, EventArgs e)
        {
            List<string> tempGuessList = Guess.Text.Split('\n').ToList();
            List<string> tempPointsList = Points.Text.Split('\n').ToList();
            NumberOfZeros.Clear();
            string tempText;
            try
            {
                for (int i = 0; i < tempGuessList.Count; i++)
                {
                    guessList.Add(Int32.Parse(tempGuessList[i]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gæt skal være tal");
            }
            try
            {
                for (int i = 0; i < tempPointsList.Count; i++)
                {
                    pointsList.Add(Int32.Parse(tempPointsList[i]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Stik skal være tal");
            }
            tempGuessList.Clear();
            tempPointsList.Clear();
            for (int i = 0; i < guessList.Count; i++)
            {
                if (guessList[i] == 0)
                {
                    playerList[i].Zeros -= 1;
                }
            }
            if (guessList.Count == playerList.Count)
            {
                if (pointsList.Count == playerList.Count)
                {
                    if (gameList[0].NumberOfCards(gameList[0].Round) == pointsList.Take(pointsList.Count).Sum())
                    {
                        {
                            Overview.Clear();
                            for (int i = 0; i < playerList.Count; i++)
                            {
                                playerList[i].UpdateScore(guessList[i], pointsList[i]);
                                Overview.AppendText(playerList[i].Name + "       " + playerList[i].Score + Environment.NewLine);
                                NumberOfZeros.AppendText(playerList[i].Zeros + Environment.NewLine);
                            }
                            gameList[0].Round += 1;
                            textBoxNumberOfCards.Text = gameList[0].NumberOfCards(gameList[0].Round).ToString();
                            Guess.Clear();
                            Points.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Antal kort i runden og antal stik stemmer ikke overens");
                    }
                }
                else
                {
                    MessageBox.Show("Antal spillere og antal point stemmer ikke overens");
                }
            }
            else
            {
                MessageBox.Show("Antal spillere og antal gæt stemmer ikke overens");
            }
            guessList.Clear();
            pointsList.Clear();
            guessListUpdate.Clear();
            if (gameList[0].GameEnded(gameList[0].Round))
            {
                tempText = Overview.Text;
                Overview.Text = (("Game Ended" + Environment.NewLine) + tempText);
                NumberOfZeros.Clear();
                Names.ReadOnly = false;
                Start.Enabled = true;
                NextRound.Enabled = false;
                textBoxNumberOfCards.Clear();
                gameList.Remove(gameList[0]);
                EndGame.Enabled = false;
                Guess.ReadOnly = true;
                Points.ReadOnly = true;
                Guess.Clear();
                Points.Clear();
            }
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            Overview.Text.Insert(0, ("Game Ended" + Environment.NewLine));
            Names.ReadOnly = false;
            Start.Enabled = true;
            NumberOfZeros.Clear();
            NextRound.Enabled = false;
            EndGame.Enabled = false;
            textBoxNumberOfCards.Clear();
            gameList.Remove(gameList[0]);
            guessList.Clear();
            pointsList.Clear();
            Guess.ReadOnly = true;
            Points.ReadOnly = true;
            Guess.Clear();
            Points.Clear();
        }

        private void Guess_TextChanged(object sender, EventArgs e)
        {
            List<string> tempGuessListUpdate = new List<string>();
            tempGuessListUpdate =  Guess.Text.Split('\n').ToList<string>();
            if (!string.IsNullOrWhiteSpace(tempGuessListUpdate.Last()))
            {
                guessListUpdate.Clear();
                try
                {
                    for (int i = 0; i < tempGuessListUpdate.Count; i++)
                    {
                        guessListUpdate.Add(Int32.Parse(tempGuessListUpdate[i]));
                    }
                    tempGuessListUpdate.Clear();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            textBoxGuessTotal.Text = guessListUpdate.Sum().ToString();
        }
    }
}
