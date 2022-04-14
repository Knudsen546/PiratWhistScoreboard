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
            pictureBoxConfetti.Visible = false;
            labelWinner.Visible = false;
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
            try
            {
                for (int i = 0; i < tempGuessList.Count; i++)
                {
                    guessList.Add(Int32.Parse(tempGuessList[i]));
                    playerList[i].Guess = Int32.Parse(tempGuessList[i]);
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
            if (guessList.Count == playerList.Count)
            {
                if (pointsList.Count == playerList.Count)
                {
                    if (gameList[0].NumberOfCards(gameList[0].Round) == pointsList.Take(pointsList.Count).Sum())
                    {
                        int k = 0;
                        for (int i = 0; i < playerList.Count; i++)
                        {
                            if (playerList[i].Zeros == 0 && playerList[i].Guess == 0)
                            {
                                MessageBox.Show(playerList[i].Name + " doesn't have more zeros");
                                k += 1;
                            }
                        }
                        Overview.Clear();
                        NumberOfZeros.Clear();
                        for (int i = 0; i < playerList.Count; i++)
                        {
                            if (k == 0)
                            {
                                if (playerList[i].Guess == 0)
                                {
                                    playerList[i].Zeros -= 1;
                                }
                                playerList[i].UpdateScore(guessList[i], pointsList[i]);
                            }
                            Overview.AppendText(playerList[i].Name + "       " + playerList[i].Score + Environment.NewLine);
                            NumberOfZeros.AppendText(playerList[i].Zeros + Environment.NewLine);
                        }
                        if (k == 0)
                        {
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
                int winner = 0;
                string tempText = Overview.Text;
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
                for (int i = 1; i < playerList.Count; i++)
                {
                    if (playerList[i].Score > playerList[winner].Score)
                    {
                        winner = i;
                        labelWinner.Text = playerList[i].Name;
                    }
                    else if (playerList[i].Score == playerList[winner].Score)
                    {
                        labelWinner.Text += ", " + playerList[i].Name;
                    }
                }
                labelWinner.Text += " has won the game with " + playerList[winner].Score + " points";
                pictureBoxConfetti.Visible = true;
                labelWinner.Visible = true;
            }
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            string tempText = Overview.Text;
            Overview.Text = (("Game Ended" + Environment.NewLine) + tempText);
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
        private void Guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter)))
                e.Handled = true;
        }
        private void Points_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter)))
                e.Handled = true;
        }

        private void Guess_TextChanged(object sender, EventArgs e)
        {
            List<string> tempGuessListUpdate = Guess.Text.Split('\n').ToList<string>();
            if (!string.IsNullOrWhiteSpace(tempGuessListUpdate.Last()) && !string.Equals(tempGuessListUpdate.Last(), "Please Enter Guesses"))
            {
                guessListUpdate.Clear();
                for (int i = 0; i < tempGuessListUpdate.Count; i++)
                {
                    try
                    {
                        guessListUpdate.Add(Int32.Parse(tempGuessListUpdate[i]));
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                tempGuessListUpdate.Clear();
            }
            textBoxGuessTotal.Text = guessListUpdate.Sum().ToString();
        }
        private Size oldSize;
        private void Form1_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.Enter))
            {
                NextRound_Click(null, System.EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Players_Enter(object sender, EventArgs e)
        {
            if (Names.Text == "Please Enter Names")
            {
                Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Names.Text = "";
                Names.ForeColor = SystemColors.WindowText;
            }
        }
        private void Players_Leave(object sender, EventArgs e)
        {
            if (Names.Text == "")
            {
                Names.ForeColor = Color.Gray;
                Names.Text = "Please Enter Names";
                Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void Guess_Enter(object sender, EventArgs e)
        {
            if (Guess.Text == "Please Enter Guesses")
            {
                Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Guess.Text = "";
                Guess.ForeColor = SystemColors.WindowText;
            }
        }
        private void Guess_Leave(object sender, EventArgs e)
        {
            if (Guess.Text == "")
            {
                Guess.ForeColor = Color.Gray;
                Guess.Text = "Please Enter Guesses";
                Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void Points_Enter(object sender, EventArgs e)
        {
            if (Points.Text == "Please Enter Points")
            {
                Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Points.ForeColor = SystemColors.WindowText;
                Points.Text = "";
            }
        }
        private void Points_Leave(object sender, EventArgs e)
        {
            if (Points.Text == "")
            {
                Points.ForeColor = Color.Gray;
                Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Points.Text = "Please Enter Points";
            }
        }
    }
}
