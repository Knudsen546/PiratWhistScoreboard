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
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start.Location = new System.Drawing.Point(12, 426);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.UseWaitCursor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Names
            // 
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Names.Location = new System.Drawing.Point(16, 43);
            this.Names.Multiline = true;
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(100, 205);
            this.Names.TabIndex = 1;
            this.Names.UseWaitCursor = true;
            this.Names.WordWrap = false;
            // 
            // Guess
            // 
            this.Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guess.Location = new System.Drawing.Point(136, 43);
            this.Guess.Multiline = true;
            this.Guess.Name = "Guess";
            this.Guess.ReadOnly = true;
            this.Guess.Size = new System.Drawing.Size(100, 205);
            this.Guess.TabIndex = 2;
            this.Guess.UseWaitCursor = true;
            this.Guess.TextChanged += new System.EventHandler(this.Guess_TextChanged);
            // 
            // Points
            // 
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.Location = new System.Drawing.Point(256, 43);
            this.Points.Multiline = true;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Size = new System.Drawing.Size(100, 205);
            this.Points.TabIndex = 3;
            this.Points.UseWaitCursor = true;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(13, 27);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(70, 13);
            this.labelPlayers.TabIndex = 7;
            this.labelPlayers.TabStop = true;
            this.labelPlayers.Text = "Insert Players";
            this.labelPlayers.UseWaitCursor = true;
            // 
            // Overview
            // 
            this.Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview.HideSelection = false;
            this.Overview.Location = new System.Drawing.Point(649, 43);
            this.Overview.Multiline = true;
            this.Overview.Name = "Overview";
            this.Overview.ReadOnly = true;
            this.Overview.Size = new System.Drawing.Size(218, 205);
            this.Overview.TabIndex = 6;
            this.Overview.TabStop = false;
            this.Overview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Overview.UseWaitCursor = true;
            // 
            // NextRound
            // 
            this.NextRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextRound.Enabled = false;
            this.NextRound.Location = new System.Drawing.Point(792, 426);
            this.NextRound.Name = "NextRound";
            this.NextRound.Size = new System.Drawing.Size(75, 23);
            this.NextRound.TabIndex = 5;
            this.NextRound.Text = "Next Round";
            this.NextRound.UseVisualStyleBackColor = true;
            this.NextRound.UseWaitCursor = true;
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
            this.labelGuess.UseWaitCursor = true;
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
            this.labelPoints.UseWaitCursor = true;
            // 
            // textBoxNumberOfCards
            // 
            this.textBoxNumberOfCards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNumberOfCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfCards.Location = new System.Drawing.Point(488, 116);
            this.textBoxNumberOfCards.Name = "textBoxNumberOfCards";
            this.textBoxNumberOfCards.ReadOnly = true;
            this.textBoxNumberOfCards.Size = new System.Drawing.Size(100, 29);
            this.textBoxNumberOfCards.TabIndex = 1;
            this.textBoxNumberOfCards.UseWaitCursor = true;
            // 
            // labelNumberOfCards
            // 
            this.labelNumberOfCards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfCards.AutoSize = true;
            this.labelNumberOfCards.Location = new System.Drawing.Point(487, 100);
            this.labelNumberOfCards.Name = "labelNumberOfCards";
            this.labelNumberOfCards.Size = new System.Drawing.Size(86, 13);
            this.labelNumberOfCards.TabIndex = 0;
            this.labelNumberOfCards.TabStop = true;
            this.labelNumberOfCards.Text = "Number of Cards";
            this.labelNumberOfCards.UseWaitCursor = true;
            // 
            // EndGame
            // 
            this.EndGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EndGame.Enabled = false;
            this.EndGame.Location = new System.Drawing.Point(93, 426);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(75, 23);
            this.EndGame.TabIndex = 8;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.UseWaitCursor = true;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // labelNumberOfZeros
            // 
            this.labelNumberOfZeros.AutoSize = true;
            this.labelNumberOfZeros.Location = new System.Drawing.Point(374, 27);
            this.labelNumberOfZeros.Name = "labelNumberOfZeros";
            this.labelNumberOfZeros.Size = new System.Drawing.Size(55, 13);
            this.labelNumberOfZeros.TabIndex = 9;
            this.labelNumberOfZeros.Text = "Zeros Left";
            this.labelNumberOfZeros.UseWaitCursor = true;
            // 
            // NumberOfZeros
            // 
            this.NumberOfZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfZeros.Location = new System.Drawing.Point(377, 43);
            this.NumberOfZeros.Multiline = true;
            this.NumberOfZeros.Name = "NumberOfZeros";
            this.NumberOfZeros.ReadOnly = true;
            this.NumberOfZeros.Size = new System.Drawing.Size(52, 205);
            this.NumberOfZeros.TabIndex = 10;
            this.NumberOfZeros.UseWaitCursor = true;
            // 
            // labelGuessTotal
            // 
            this.labelGuessTotal.AutoSize = true;
            this.labelGuessTotal.Location = new System.Drawing.Point(67, 261);
            this.labelGuessTotal.Name = "labelGuessTotal";
            this.labelGuessTotal.Size = new System.Drawing.Size(67, 13);
            this.labelGuessTotal.TabIndex = 11;
            this.labelGuessTotal.Text = "Guess Total:";
            this.labelGuessTotal.UseWaitCursor = true;
            // 
            // textBoxGuessTotal
            // 
            this.textBoxGuessTotal.Location = new System.Drawing.Point(136, 258);
            this.textBoxGuessTotal.Name = "textBoxGuessTotal";
            this.textBoxGuessTotal.ReadOnly = true;
            this.textBoxGuessTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxGuessTotal.TabIndex = 12;
            this.textBoxGuessTotal.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 461);
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
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "Pirat Whist Scoreboard";
            this.UseWaitCursor = true;
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
    }
}

