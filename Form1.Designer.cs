using System;

namespace PiratWhistScoreboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.TextBox();
            this.Guess = new System.Windows.Forms.TextBox();
            this.Points = new System.Windows.Forms.TextBox();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.Overview = new System.Windows.Forms.TextBox();
            this.NextRound = new System.Windows.Forms.Button();
            this.labelGuess = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBoxNumberOfCards = new System.Windows.Forms.TextBox();
            this.labelNumberOfCards = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.Button();
            this.labelNumberOfZeros = new System.Windows.Forms.Label();
            this.NumberOfZeros = new System.Windows.Forms.TextBox();
            this.labelGuessTotal = new System.Windows.Forms.Label();
            this.textBoxGuessTotal = new System.Windows.Forms.TextBox();
            this.pictureBoxConfetti = new System.Windows.Forms.PictureBox();
            this.textBoxWinner = new System.Windows.Forms.TextBox();
            this.labelDiffernce = new System.Windows.Forms.Label();
            this.textBoxDifference = new System.Windows.Forms.TextBox();
            this.textBoxStreak = new System.Windows.Forms.TextBox();
            this.labelStreak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfetti)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(19, 593);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Names
            // 
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Names.ForeColor = System.Drawing.Color.Gray;
            this.Names.Location = new System.Drawing.Point(17, 47);
            this.Names.Multiline = true;
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(210, 251);
            this.Names.TabIndex = 1;
            this.Names.Text = "Please Enter Names";
            this.Names.WordWrap = false;
            this.Names.Enter += new System.EventHandler(this.Players_Enter);
            this.Names.Leave += new System.EventHandler(this.Players_Leave);
            // 
            // Guess
            // 
            this.Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guess.ForeColor = System.Drawing.Color.Gray;
            this.Guess.Location = new System.Drawing.Point(415, 47);
            this.Guess.Multiline = true;
            this.Guess.Name = "Guess";
            this.Guess.ReadOnly = true;
            this.Guess.Size = new System.Drawing.Size(64, 251);
            this.Guess.TabIndex = 2;
            this.Guess.TextChanged += new System.EventHandler(this.Guess_TextChanged);
            this.Guess.Enter += new System.EventHandler(this.Guess_Enter);
            this.Guess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            this.Guess.Leave += new System.EventHandler(this.Guess_Leave);
            // 
            // Points
            // 
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.ForeColor = System.Drawing.Color.Gray;
            this.Points.Location = new System.Drawing.Point(552, 47);
            this.Points.Multiline = true;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Size = new System.Drawing.Size(64, 251);
            this.Points.TabIndex = 3;
            this.Points.Enter += new System.EventHandler(this.Points_Enter);
            this.Points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Points_KeyPress);
            this.Points.Leave += new System.EventHandler(this.Points_Leave);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers.Location = new System.Drawing.Point(13, 9);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(105, 31);
            this.labelPlayers.TabIndex = 7;
            this.labelPlayers.Text = "Players";
            // 
            // Overview
            // 
            this.Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview.HideSelection = false;
            this.Overview.Location = new System.Drawing.Point(860, 47);
            this.Overview.Multiline = true;
            this.Overview.Name = "Overview";
            this.Overview.ReadOnly = true;
            this.Overview.Size = new System.Drawing.Size(248, 251);
            this.Overview.TabIndex = 6;
            this.Overview.TabStop = false;
            this.Overview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NextRound
            // 
            this.NextRound.Enabled = false;
            this.NextRound.Location = new System.Drawing.Point(1033, 593);
            this.NextRound.Name = "NextRound";
            this.NextRound.Size = new System.Drawing.Size(75, 23);
            this.NextRound.TabIndex = 5;
            this.NextRound.Text = "Next Round";
            this.NextRound.UseVisualStyleBackColor = true;
            this.NextRound.Click += new System.EventHandler(this.NextRound_Click);
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuess.Location = new System.Drawing.Point(400, 9);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(93, 31);
            this.labelGuess.TabIndex = 3;
            this.labelGuess.Text = "Guess";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(539, 9);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(90, 31);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "Points";
            // 
            // textBoxNumberOfCards
            // 
            this.textBoxNumberOfCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfCards.Location = new System.Drawing.Point(415, 348);
            this.textBoxNumberOfCards.Name = "textBoxNumberOfCards";
            this.textBoxNumberOfCards.ReadOnly = true;
            this.textBoxNumberOfCards.Size = new System.Drawing.Size(64, 38);
            this.textBoxNumberOfCards.TabIndex = 1;
            this.textBoxNumberOfCards.TabStop = false;
            // 
            // labelNumberOfCards
            // 
            this.labelNumberOfCards.AutoSize = true;
            this.labelNumberOfCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfCards.Location = new System.Drawing.Point(181, 351);
            this.labelNumberOfCards.Name = "labelNumberOfCards";
            this.labelNumberOfCards.Size = new System.Drawing.Size(228, 31);
            this.labelNumberOfCards.TabIndex = 0;
            this.labelNumberOfCards.Text = "Number of Cards:";
            this.labelNumberOfCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndGame
            // 
            this.EndGame.Enabled = false;
            this.EndGame.Location = new System.Drawing.Point(100, 593);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(75, 23);
            this.EndGame.TabIndex = 8;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // labelNumberOfZeros
            // 
            this.labelNumberOfZeros.AutoSize = true;
            this.labelNumberOfZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfZeros.Location = new System.Drawing.Point(240, 9);
            this.labelNumberOfZeros.Name = "labelNumberOfZeros";
            this.labelNumberOfZeros.Size = new System.Drawing.Size(137, 31);
            this.labelNumberOfZeros.TabIndex = 9;
            this.labelNumberOfZeros.Text = "Zeros Left";
            // 
            // NumberOfZeros
            // 
            this.NumberOfZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfZeros.Location = new System.Drawing.Point(279, 47);
            this.NumberOfZeros.Multiline = true;
            this.NumberOfZeros.Name = "NumberOfZeros";
            this.NumberOfZeros.ReadOnly = true;
            this.NumberOfZeros.Size = new System.Drawing.Size(64, 251);
            this.NumberOfZeros.TabIndex = 10;
            this.NumberOfZeros.TabStop = false;
            // 
            // labelGuessTotal
            // 
            this.labelGuessTotal.AutoSize = true;
            this.labelGuessTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessTotal.Location = new System.Drawing.Point(240, 307);
            this.labelGuessTotal.Name = "labelGuessTotal";
            this.labelGuessTotal.Size = new System.Drawing.Size(169, 31);
            this.labelGuessTotal.TabIndex = 11;
            this.labelGuessTotal.Text = "Guess Total:";
            this.labelGuessTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGuessTotal
            // 
            this.textBoxGuessTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuessTotal.Location = new System.Drawing.Point(415, 304);
            this.textBoxGuessTotal.Name = "textBoxGuessTotal";
            this.textBoxGuessTotal.ReadOnly = true;
            this.textBoxGuessTotal.Size = new System.Drawing.Size(64, 38);
            this.textBoxGuessTotal.TabIndex = 12;
            this.textBoxGuessTotal.TabStop = false;
            // 
            // pictureBoxConfetti
            // 
            this.pictureBoxConfetti.Image = global::PiratVestScoreboard.Properties.Resources.confetti;
            this.pictureBoxConfetti.Location = new System.Drawing.Point(279, 143);
            this.pictureBoxConfetti.Name = "pictureBoxConfetti";
            this.pictureBoxConfetti.Size = new System.Drawing.Size(520, 350);
            this.pictureBoxConfetti.TabIndex = 13;
            this.pictureBoxConfetti.TabStop = false;
            this.pictureBoxConfetti.Visible = false;
            // 
            // textBoxWinner
            // 
            this.textBoxWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWinner.Location = new System.Drawing.Point(290, 284);
            this.textBoxWinner.MaximumSize = new System.Drawing.Size(495, 64);
            this.textBoxWinner.MinimumSize = new System.Drawing.Size(495, 64);
            this.textBoxWinner.Multiline = true;
            this.textBoxWinner.Name = "textBoxWinner";
            this.textBoxWinner.ReadOnly = true;
            this.textBoxWinner.Size = new System.Drawing.Size(495, 64);
            this.textBoxWinner.TabIndex = 14;
            this.textBoxWinner.TabStop = false;
            this.textBoxWinner.Visible = false;
            // 
            // labelDiffernce
            // 
            this.labelDiffernce.AutoSize = true;
            this.labelDiffernce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiffernce.Location = new System.Drawing.Point(262, 395);
            this.labelDiffernce.Name = "labelDiffernce";
            this.labelDiffernce.Size = new System.Drawing.Size(147, 31);
            this.labelDiffernce.TabIndex = 15;
            this.labelDiffernce.Text = "Difference:";
            this.labelDiffernce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDifference
            // 
            this.textBoxDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDifference.Location = new System.Drawing.Point(415, 392);
            this.textBoxDifference.Name = "textBoxDifference";
            this.textBoxDifference.ReadOnly = true;
            this.textBoxDifference.Size = new System.Drawing.Size(64, 38);
            this.textBoxDifference.TabIndex = 16;
            this.textBoxDifference.TabStop = false;
            // 
            // textBoxStreak
            // 
            this.textBoxStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreak.Location = new System.Drawing.Point(776, 47);
            this.textBoxStreak.Multiline = true;
            this.textBoxStreak.Name = "textBoxStreak";
            this.textBoxStreak.ReadOnly = true;
            this.textBoxStreak.Size = new System.Drawing.Size(64, 251);
            this.textBoxStreak.TabIndex = 18;
            this.textBoxStreak.TabStop = false;
            // 
            // labelStreak
            // 
            this.labelStreak.AutoSize = true;
            this.labelStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreak.Location = new System.Drawing.Point(761, 9);
            this.labelStreak.Name = "labelStreak";
            this.labelStreak.Size = new System.Drawing.Size(93, 31);
            this.labelStreak.TabIndex = 17;
            this.labelStreak.Text = "Streak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1120, 628);
            this.Controls.Add(this.pictureBoxConfetti);
            this.Controls.Add(this.textBoxStreak);
            this.Controls.Add(this.labelStreak);
            this.Controls.Add(this.labelDiffernce);
            this.Controls.Add(this.textBoxDifference);
            this.Controls.Add(this.textBoxWinner);
            this.Controls.Add(this.textBoxGuessTotal);
            this.Controls.Add(this.labelGuessTotal);
            this.Controls.Add(this.NumberOfZeros);
            this.Controls.Add(this.labelNumberOfZeros);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.labelNumberOfCards);
            this.Controls.Add(this.textBoxNumberOfCards);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelGuess);
            this.Controls.Add(this.NextRound);
            this.Controls.Add(this.Overview);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Start);
            this.MinimumSize = new System.Drawing.Size(1136, 667);
            this.Name = "Form1";
            this.Text = "Pirat Whist Scoreboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfetti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.TextBox Names;
        public System.Windows.Forms.TextBox Guess;
        public System.Windows.Forms.TextBox Points;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.TextBox Overview;
        private System.Windows.Forms.Button NextRound;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox textBoxNumberOfCards;
        private System.Windows.Forms.Label labelNumberOfCards;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.Label labelNumberOfZeros;
        private System.Windows.Forms.TextBox NumberOfZeros;
        private System.Windows.Forms.Label labelGuessTotal;
        private System.Windows.Forms.TextBox textBoxGuessTotal;
        private System.Windows.Forms.PictureBox pictureBoxConfetti;
        private System.Windows.Forms.TextBox textBoxWinner;
        private System.Windows.Forms.Label labelDiffernce;
        private System.Windows.Forms.TextBox textBoxDifference;
        private System.Windows.Forms.TextBox textBoxStreak;
        private System.Windows.Forms.Label labelStreak;
    }
}

