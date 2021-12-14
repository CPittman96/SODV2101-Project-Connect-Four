
namespace ConnectFourApp
{
    partial class ConnectFourBoard
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnMusicToggle = new System.Windows.Forms.Button();
            this.btnEffectsToggle = new System.Windows.Forms.Button();
            this.lblTurnPlayer = new System.Windows.Forms.Label();
            this.lblScoreRed = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScoreYellow = new System.Windows.Forms.Label();
            this.lblTurnColour = new System.Windows.Forms.Label();
            this.lblScoreNumRed = new System.Windows.Forms.Label();
            this.lblScoreNumYellow = new System.Windows.Forms.Label();
            this.lblScoreDraw = new System.Windows.Forms.Label();
            this.lblScoreNumDraw = new System.Windows.Forms.Label();
            this.lblRoundNum = new System.Windows.Forms.Label();
            this.lblRoundTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(355, 17);
            this.lblGameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(261, 44);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Connect Four";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel.Location = new System.Drawing.Point(127, 143);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(715, 555);
            this.panel.TabIndex = 1;
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(127, 774);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(220, 60);
            this.btnResetGame.TabIndex = 2;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnMusicToggle
            // 
            this.btnMusicToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicToggle.Location = new System.Drawing.Point(375, 774);
            this.btnMusicToggle.Name = "btnMusicToggle";
            this.btnMusicToggle.Size = new System.Drawing.Size(220, 60);
            this.btnMusicToggle.TabIndex = 3;
            this.btnMusicToggle.Text = "Music Toggle";
            this.btnMusicToggle.UseVisualStyleBackColor = true;
            this.btnMusicToggle.Click += new System.EventHandler(this.btnMusicToggle_Click);
            // 
            // btnEffectsToggle
            // 
            this.btnEffectsToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffectsToggle.Location = new System.Drawing.Point(622, 774);
            this.btnEffectsToggle.Name = "btnEffectsToggle";
            this.btnEffectsToggle.Size = new System.Drawing.Size(220, 60);
            this.btnEffectsToggle.TabIndex = 4;
            this.btnEffectsToggle.Text = "Sound Effects";
            this.btnEffectsToggle.UseVisualStyleBackColor = true;
            this.btnEffectsToggle.Click += new System.EventHandler(this.btnEffectsToggle_Click);
            // 
            // lblTurnPlayer
            // 
            this.lblTurnPlayer.AutoSize = true;
            this.lblTurnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnPlayer.Location = new System.Drawing.Point(147, 84);
            this.lblTurnPlayer.Name = "lblTurnPlayer";
            this.lblTurnPlayer.Size = new System.Drawing.Size(149, 29);
            this.lblTurnPlayer.TabIndex = 5;
            this.lblTurnPlayer.Text = "Player Turn :";
            // 
            // lblScoreRed
            // 
            this.lblScoreRed.AutoSize = true;
            this.lblScoreRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreRed.Location = new System.Drawing.Point(742, 55);
            this.lblScoreRed.Name = "lblScoreRed";
            this.lblScoreRed.Size = new System.Drawing.Size(70, 29);
            this.lblScoreRed.TabIndex = 6;
            this.lblScoreRed.Text = "Red :";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(713, 17);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(151, 29);
            this.lblScoreTitle.TabIndex = 7;
            this.lblScoreTitle.Text = "Player Score";
            // 
            // lblScoreYellow
            // 
            this.lblScoreYellow.AutoSize = true;
            this.lblScoreYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreYellow.Location = new System.Drawing.Point(713, 84);
            this.lblScoreYellow.Name = "lblScoreYellow";
            this.lblScoreYellow.Size = new System.Drawing.Size(99, 29);
            this.lblScoreYellow.TabIndex = 8;
            this.lblScoreYellow.Text = "Yellow :";
            // 
            // lblTurnColour
            // 
            this.lblTurnColour.AutoSize = true;
            this.lblTurnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnColour.Location = new System.Drawing.Point(290, 84);
            this.lblTurnColour.Name = "lblTurnColour";
            this.lblTurnColour.Size = new System.Drawing.Size(58, 29);
            this.lblTurnColour.TabIndex = 9;
            this.lblTurnColour.Text = "Red";
            // 
            // lblScoreNumRed
            // 
            this.lblScoreNumRed.AutoSize = true;
            this.lblScoreNumRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumRed.Location = new System.Drawing.Point(818, 55);
            this.lblScoreNumRed.Name = "lblScoreNumRed";
            this.lblScoreNumRed.Size = new System.Drawing.Size(26, 29);
            this.lblScoreNumRed.TabIndex = 10;
            this.lblScoreNumRed.Text = "0";
            // 
            // lblScoreNumYellow
            // 
            this.lblScoreNumYellow.AutoSize = true;
            this.lblScoreNumYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumYellow.Location = new System.Drawing.Point(818, 84);
            this.lblScoreNumYellow.Name = "lblScoreNumYellow";
            this.lblScoreNumYellow.Size = new System.Drawing.Size(26, 29);
            this.lblScoreNumYellow.TabIndex = 11;
            this.lblScoreNumYellow.Text = "0";
            // 
            // lblScoreDraw
            // 
            this.lblScoreDraw.AutoSize = true;
            this.lblScoreDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDraw.Location = new System.Drawing.Point(731, 112);
            this.lblScoreDraw.Name = "lblScoreDraw";
            this.lblScoreDraw.Size = new System.Drawing.Size(81, 29);
            this.lblScoreDraw.TabIndex = 12;
            this.lblScoreDraw.Text = "Draw :";
            // 
            // lblScoreNumDraw
            // 
            this.lblScoreNumDraw.AutoSize = true;
            this.lblScoreNumDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumDraw.Location = new System.Drawing.Point(818, 113);
            this.lblScoreNumDraw.Name = "lblScoreNumDraw";
            this.lblScoreNumDraw.Size = new System.Drawing.Size(26, 29);
            this.lblScoreNumDraw.TabIndex = 13;
            this.lblScoreNumDraw.Text = "0";
            // 
            // lblRoundNum
            // 
            this.lblRoundNum.AutoSize = true;
            this.lblRoundNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNum.Location = new System.Drawing.Point(538, 84);
            this.lblRoundNum.Name = "lblRoundNum";
            this.lblRoundNum.Size = new System.Drawing.Size(26, 29);
            this.lblRoundNum.TabIndex = 14;
            this.lblRoundNum.Text = "0";
            // 
            // lblRoundTitle
            // 
            this.lblRoundTitle.AutoSize = true;
            this.lblRoundTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTitle.Location = new System.Drawing.Point(436, 84);
            this.lblRoundTitle.Name = "lblRoundTitle";
            this.lblRoundTitle.Size = new System.Drawing.Size(96, 29);
            this.lblRoundTitle.TabIndex = 15;
            this.lblRoundTitle.Text = "Round :";
            // 
            // ConnectFourBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.lblRoundTitle);
            this.Controls.Add(this.lblRoundNum);
            this.Controls.Add(this.lblScoreNumDraw);
            this.Controls.Add(this.lblScoreDraw);
            this.Controls.Add(this.lblScoreNumYellow);
            this.Controls.Add(this.lblScoreNumRed);
            this.Controls.Add(this.lblTurnColour);
            this.Controls.Add(this.lblScoreYellow);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblScoreRed);
            this.Controls.Add(this.lblTurnPlayer);
            this.Controls.Add(this.btnEffectsToggle);
            this.Controls.Add(this.btnMusicToggle);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblGameTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConnectFourBoard";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.ConnectFourBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnMusicToggle;
        private System.Windows.Forms.Button btnEffectsToggle;
        private System.Windows.Forms.Label lblTurnPlayer;
        private System.Windows.Forms.Label lblScoreRed;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScoreYellow;
        private System.Windows.Forms.Label lblTurnColour;
        private System.Windows.Forms.Label lblScoreNumRed;
        private System.Windows.Forms.Label lblScoreNumYellow;
        private System.Windows.Forms.Label lblScoreDraw;
        private System.Windows.Forms.Label lblScoreNumDraw;
        private System.Windows.Forms.Label lblRoundNum;
        private System.Windows.Forms.Label lblRoundTitle;
    }
}

