using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiratVestScoreboard
{
    public partial class Form1 : Form
    {
        public List<string> textList = new List<string>();
        public List<Player> playerList = new List<Player>();
        public List<int> guessList = new List<int>();
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
            gameList.Add(new Game(textList.Count, 1));
            foreach (string name in textList)
            {
                Player player = new Player(name);
                playerList.Add(player);
            }
            textBoxNumberOfCards.Text = gameList[0].NumberOfCards(gameList[0].Round).ToString();
        }

        private void NextRound_Click(object sender, EventArgs e)
        {
            List<string> tempGuessList = Guess.Text.Split('\n').ToList();
            List<string> tempPointsList = Points.Text.Split('\n').ToList();
            if (gameList[0].GameEnded(gameList[0].Round))
            {
                Overview.Text.Insert(0, ("Game Ended" + Environment.NewLine));
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
            else
            {
                Overview.Clear();
                try
                {
                    for (int i = 0; i < tempGuessList.Count; i++)
                    {
                        guessList.Add(Int32.Parse(tempGuessList[i]));
                        pointsList.Add(Int32.Parse(tempPointsList[i]));
                    }
                    tempGuessList.Clear();
                    tempPointsList.Clear();
                    if (guessList.Count == playerList.Count && pointsList.Count == playerList.Count && (gameList[0].NumberOfCards(gameList[0].Round) == pointsList.Take(pointsList.Count).Sum()))
                    {
                        for (int i = 0; i < playerList.Count; i++)
                        {
                            playerList[i].UpdateScore(guessList[i], pointsList[i]);
                            Overview.AppendText(playerList[i].Name + "   " + playerList[i].Score.ToString() + Environment.NewLine);
                        }
                        gameList[0].Round += 1;
                        textBoxNumberOfCards.Text = gameList[0].NumberOfCards(gameList[0].Round).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Number of Players, Guesses, Points and number of cards are not correct", "Fucking Fejl", MessageBoxButtons.OK);
                    }
                    guessList.Clear();
                    pointsList.Clear();
                    Guess.Clear();
                    Points.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Guess or Points is not correct", "Fucking Fejl", MessageBoxButtons.OK);
                }
            }
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            Overview.Text.Insert(0, ("Game Ended" + Environment.NewLine));
            Names.ReadOnly = false;
            Start.Enabled = true;
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
    }
}
