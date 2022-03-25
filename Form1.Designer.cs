using System;

namespace PiratVestScoreboard
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
            this.players = new System.Windows.Forms.Label();
            this.Overview = new System.Windows.Forms.TextBox();
            this.NextRound = new System.Windows.Forms.Button();
            this.labelGuess = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBoxNumberOfCards = new System.Windows.Forms.TextBox();
            this.labelNumberOfCards = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 415);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(16, 43);
            this.Names.Multiline = true;
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(100, 205);
            this.Names.TabIndex = 1;
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(136, 43);
            this.Guess.Multiline = true;
            this.Guess.Name = "Guess";
            this.Guess.ReadOnly = true;
            this.Guess.Size = new System.Drawing.Size(100, 205);
            this.Guess.TabIndex = 2;
            // 
            // Points
            // 
            this.Points.Location = new System.Drawing.Point(256, 43);
            this.Points.Multiline = true;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Size = new System.Drawing.Size(100, 205);
            this.Points.TabIndex = 3;
            // 
            // players
            // 
            this.players.AutoSize = true;
            this.players.Location = new System.Drawing.Point(13, 27);
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(70, 13);
            this.players.TabIndex = 7;
            this.players.TabStop = true;
            this.players.Text = "Insert Players";
            // 
            // Overview
            // 
            this.Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview.HideSelection = false;
            this.Overview.Location = new System.Drawing.Point(570, 43);
            this.Overview.Multiline = true;
            this.Overview.Name = "Overview";
            this.Overview.ReadOnly = true;
            this.Overview.Size = new System.Drawing.Size(218, 205);
            this.Overview.TabIndex = 6;
            // 
            // NextRound
            // 
            this.NextRound.Enabled = false;
            this.NextRound.Location = new System.Drawing.Point(713, 415);
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
            this.labelGuess.Location = new System.Drawing.Point(136, 27);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(66, 13);
            this.labelGuess.TabIndex = 3;
            this.labelGuess.TabStop = true;
            this.labelGuess.Text = "Insert Guess";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(256, 27);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(65, 13);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.TabStop = true;
            this.labelPoints.Text = "Insert Points";
            // 
            // textBoxNumberOfCards
            // 
            this.textBoxNumberOfCards.Location = new System.Drawing.Point(408, 116);
            this.textBoxNumberOfCards.Name = "textBoxNumberOfCards";
            this.textBoxNumberOfCards.ReadOnly = true;
            this.textBoxNumberOfCards.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfCards.TabIndex = 1;
            // 
            // labelNumberOfCards
            // 
            this.labelNumberOfCards.AutoSize = true;
            this.labelNumberOfCards.Location = new System.Drawing.Point(411, 100);
            this.labelNumberOfCards.Name = "labelNumberOfCards";
            this.labelNumberOfCards.Size = new System.Drawing.Size(86, 13);
            this.labelNumberOfCards.TabIndex = 0;
            this.labelNumberOfCards.TabStop = true;
            this.labelNumberOfCards.Text = "Number of Cards";
            // 
            // EndGame
            // 
            this.EndGame.Location = new System.Drawing.Point(93, 415);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(75, 23);
            this.EndGame.TabIndex = 8;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            this.EndGame.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.labelNumberOfCards);
            this.Controls.Add(this.textBoxNumberOfCards);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelGuess);
            this.Controls.Add(this.NextRound);
            this.Controls.Add(this.Overview);
            this.Controls.Add(this.players);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Pirat Vest Scoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.TextBox Names;
        public System.Windows.Forms.TextBox Guess;
        public System.Windows.Forms.TextBox Points;
        private System.Windows.Forms.Label players;
        private System.Windows.Forms.TextBox Overview;
        private System.Windows.Forms.Button NextRound;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox textBoxNumberOfCards;
        private System.Windows.Forms.Label labelNumberOfCards;
        private System.Windows.Forms.Button EndGame;
    }
}

