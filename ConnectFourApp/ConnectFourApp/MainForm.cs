using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ConnectFourApp
{
    public partial class ConnectFourBoard : Form
    {
        private Button hoveredBtn = new Button();
        private static Image whiteImg = new Bitmap(Image.FromFile("WhiteChecker.png"));
        private static Image yellowImg = new Bitmap(Image.FromFile("YellowChecker.png"));
        private static Image redImg = new Bitmap(Image.FromFile("RedChecker.png"));
        private Image white = (Image)(new Bitmap(whiteImg, new Size(101, 101)));
        private Image yellow = (Image)(new Bitmap(yellowImg, new Size(101, 101)));
        private Image red = (Image)(new Bitmap(redImg, new Size(101, 101)));
        private static Board ConnectBoard = new Board(7, 6);
        private static Button[,] btnTable = new Button[ConnectBoard.SizeW, ConnectBoard.SizeH];
        private bool turn = true;
        private bool winner = false;
        private bool draw = false;
        private Button prevButton;
        public WindowsMediaPlayer gameMusicPlayer;
        public WindowsMediaPlayer gameEffectPlayer1;
        public WindowsMediaPlayer gameEffectPlayer2;
        public WindowsMediaPlayer gameEffectPlayer3;
        public WindowsMediaPlayer gameEffectPlayer4;
        private bool musicToggle = true;
        private bool effectToggle = true;
        public static float roundTotal = 0;
        public bool isWinner = false;
        public bool isDraw = false;

        //int roundCurrent = 0;
        private int redPlayerScore = 0;

        private int yellowPlayerScore = 0;

        private void generateTable()
        {
            //panel.BackgroundImage = red;
            int btnSize = panel.Width / 7;

            panel.Height = btnSize * 6;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    btnTable[i, j] = new Button();
                    btnTable[i, j].Height = btnSize;
                    btnTable[i, j].Width = btnSize;
                    btnTable[i, j].Click += TableBtnClick;
                    ConnectBoard.table[1, j].isRed = true;

                    panel.Controls.Add(btnTable[i, j]);

                    btnTable[i, j].Location = new Point(i * btnSize, j * btnSize);

                    btnTable[i, j].Tag = new Point(i, j);

                    btnTable[i, j].BackgroundImage = white;
                }
            }
        }

        public ConnectFourBoard()
        {
            InitializeComponent();
            generateTable();
        }

        private void ConnectFourBoard_Load(object sender, EventArgs e)
        {
            lblScoreNumRed.Text = redPlayerScore.ToString();
            lblScoreNumYellow.Text = yellowPlayerScore.ToString();
            lblTurnColour.Text = "Red";
            turn = true;
            gameMusicStart();
            gameSoundSetup();
            gameScoreTrackBegin();
        }

        private void TableBtnClick(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            Cell thisCell = new Cell(clickedBtn.Location.X, clickedBtn.Location.Y);

            // Clicking on an occupied tile (red/yellow)
            if ((clickedBtn.BackgroundImage == red || clickedBtn.BackgroundImage == yellow) && winner == false && draw == false)
            {
                // Check if sound effects are toggled on
                if (effectToggle == true)
                {
                    // Play this sound effect when clicking on an occupied tile (red/yellow)
                    gameEffectPlayer2.URL = "GameEffectTileError (japanyoshithegamer__8-bit-wrong-sound).wav";
                    gameEffectPlayer2.controls.play();
                }
            }

            // Clicking on an empty tile (white)
            if (clickedBtn.BackgroundImage == white && winner == false && draw == false)
            {
                // Check if sound effects are toggled on
                if (effectToggle == true)
                {
                    // Play this sound effect when clicking on an empty tile (white)
                    gameEffectPlayer1.URL = "GameEffectTilePlace (japanyoshithegamer__8-bit-soft-hi-hat).wav";
                    gameEffectPlayer1.controls.play();
                }

                // Change Player Turn Label text
                if (turn == false)
                {
                    lblTurnColour.Text = "Red";
                }
                else
                {
                    lblTurnColour.Text = "Yellow";
                }

                // Call function to place tile
                canPlace(clickedBtn.Location.X, btnTable);
            }
        }

        private void checkAmount(int amount)
        {
            if (amount == 4)
            {
                Console.WriteLine("We have a Winner!");
                isWinner = true;
            }
            else
            {
                amount = 0;
            }
        }

        private void checkVert(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x, y + 3].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x, y + 2].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x, y + 1].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x, y].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount);
            }
            catch
            {
            }
        }

        private void checkHorz1(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x, y].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x + 1, y].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x + 2, y].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x + 3, y].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount);
            }
            catch { }
        }

        private void checkHorz2(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x, y].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x - 1, y].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x - 2, y].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x - 3, y].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount);
            }
            catch { }
        }

        private void checkHorz3(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x - 2, y].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x - 1, y].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x, y].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x + 1, y].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount);
            }
            catch { }
        }

        private void checkHorz4(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x - 1, y].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x, y].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x + 1, y].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x + 2, y].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount); ;
            }
            catch { }
        }

        private void checkCross1(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x, y].BackgroundImage == color)
                {
                    Console.WriteLine("+0");
                    amount++;
                    if (btnTable[x + 1, y + 1].BackgroundImage == color)
                    {
                        Console.WriteLine("+1");
                        amount++;
                        if (btnTable[x + 2, y + 2].BackgroundImage == color)
                        {
                            Console.WriteLine("+2");
                            amount++;
                            if (btnTable[x + 3, y + 3].BackgroundImage == color)
                            {
                                Console.WriteLine("+3");
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount); ;
            }
            catch { }
        }

        private void checkCross2(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x, y].BackgroundImage == color)
                {
                    Console.WriteLine("-0");
                    amount++;
                    if (btnTable[x - 1, y + 1].BackgroundImage == color)
                    {
                        Console.WriteLine("-1");
                        amount++;
                        if (btnTable[x - 2, y + 2].BackgroundImage == color)
                        {
                            Console.WriteLine("-2");
                            amount++;
                            if (btnTable[x - 3, y + 3].BackgroundImage == color)
                            {
                                Console.WriteLine("-3");
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount); ;
            }
            catch { }
        }

        private void checkCross3(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x - 1, y + 1].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x, y].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x + 1, y + 1].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x + 2, y - 2].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount); ;
            }
            catch { }
        }

        private void checkCross4(Image color, int x, int y, Button[,] btnTable)
        {
            int amount = 0;
            try
            {
                if (btnTable[x - 2, y - 2].BackgroundImage == color)
                {
                    amount++;
                    if (btnTable[x - 1, y - 1].BackgroundImage == color)
                    {
                        amount++;
                        if (btnTable[x, y].BackgroundImage == color)
                        {
                            amount++;
                            if (btnTable[x + 1, y + 1].BackgroundImage == color)
                            {
                                amount++;
                            }
                        }
                    }
                }
                checkAmount(amount); ;
            }
            catch { }
        }

        private void isRndDraw()
        {
            int number = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (btnTable[i, j].BackgroundImage != white)
                    {
                        number++;
                    }
                }
            }
            if (number >= 42)
            {
                isDraw = true;
            }
        }

        private void canPlace(int x, Button[,] btnTable)
        {
            Image putImg = white;

            int y = -1;

            if (isWinner == false && isDraw == false)
            {
                if (turn)
                {
                    putImg = red;
                    turn = false;
                }
                else
                {
                    putImg = yellow;
                    turn = true;
                }

                //the location comes in with a diffrent number so this sets it to the correct number
                switch (x)
                {
                    case 612:
                        x = 6;
                        break;

                    case 510:
                        x = 5;
                        break;

                    case 408:
                        x = 4;
                        break;

                    case 306:
                        x = 3;
                        break;

                    case 204:
                        x = 2;
                        break;

                    case 102:
                        x = 1;
                        break;

                    default:
                        x = 0;
                        break;
                }
                //this put the checker at the bottom
                if (btnTable[x, 5].BackgroundImage == white)
                {
                    btnTable[x, 5].BackgroundImage = putImg;
                    y = 5;
                }
                else if (btnTable[x, 4].BackgroundImage == white)
                {
                    btnTable[x, 4].BackgroundImage = putImg;
                    y = 4;
                }
                else if (btnTable[x, 3].BackgroundImage == white)
                {
                    btnTable[x, 3].BackgroundImage = putImg;
                    y = 3;
                }
                else if (btnTable[x, 2].BackgroundImage == white)
                {
                    btnTable[x, 2].BackgroundImage = putImg;
                    y = 2;
                }
                else if (btnTable[x, 1].BackgroundImage == white)
                {
                    btnTable[x, 1].BackgroundImage = putImg;
                    y = 1;
                }
                else if (btnTable[x, 0].BackgroundImage == white)
                {
                    btnTable[x, 0].BackgroundImage = putImg;
                    y = 0;
                }
                if (y != -1)
                {
                    checkVert(putImg, x, y, btnTable);
                    checkHorz1(putImg, x, y, btnTable);
                    checkHorz2(putImg, x, y, btnTable);
                    checkHorz3(putImg, x, y, btnTable);
                    checkHorz4(putImg, x, y, btnTable);
                    checkCross1(putImg, x, y, btnTable);
                    checkCross2(putImg, x, y, btnTable);
                    checkCross3(putImg, x, y, btnTable);
                    checkCross4(putImg, x, y, btnTable);
                    isRndDraw();
                }
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            // Set all tiles to white (default)
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    btnTable[i, j].BackgroundImage = white;
                }
            }

            isWinner = false;
            isDraw = false;

            // Set player turn to red (default)
            lblTurnColour.Text = "Red";
            turn = true;

            // Set player scores to zero (default)
            redPlayerScore = 0;
            yellowPlayerScore = 0;
        }

        private void btnMusicToggle_Click(object sender, EventArgs e)
        {
            // Turn off music if currently on,
            // otherwise turn on music
            if (musicToggle == true)
            {
                // Stop music
                gameMusicPlayer.controls.stop();
                musicToggle = false;
            }
            else
            {
                // Resume music
                gameMusicPlayer.controls.play();
                musicToggle = true;
            }
        }

        private void btnEffectsToggle_Click(object sender, EventArgs e)
        {
            // Set effectToggle to false if currently true,
            // otherwise set effectToggle to true
            if (effectToggle == true)
            {
                effectToggle = false;
            }
            else
            {
                effectToggle = true;
            }
        }

        public void gameMusicStart()
        {
            // Create WindowsMediaPlayer object for music
            gameMusicPlayer = new WindowsMediaPlayer();
            gameMusicPlayer.URL = "GameMusic (djgriffin__video-game-7).wav";
            gameMusicPlayer.settings.volume = 10;
            gameMusicPlayer.settings.setMode("Loop", true);
        }

        public void gameSoundSetup()
        {
            // Create WindowsMediaPlayer objects
            gameEffectPlayer1 = new WindowsMediaPlayer();
            gameEffectPlayer2 = new WindowsMediaPlayer();
            gameEffectPlayer3 = new WindowsMediaPlayer();
            gameEffectPlayer4 = new WindowsMediaPlayer();

            // Set volume setting for sound effects
            gameEffectPlayer1.settings.volume = 100;
            gameEffectPlayer2.settings.volume = 10;
            gameEffectPlayer3.settings.volume = 100;
            gameEffectPlayer4.settings.volume = 100;

            // Insert the following at win condition check
            //if (effectToggle == true)
            //{
            //gameEffectPlayer3.URL = "GameEffectWin (mativve__electro-success-sound).wav";
            //gameEffectPlayer3.controls.play();
            //}

            // Insert the following at draw condition check
            //if (effectToggle == true)
            //{
            //gameEffectPlayer4.URL = "GameEffectDraw (raclure__damage-sound-effect).wav";
            //gameEffectPlayer4.controls.play();
            //}
        }

        public void gameScoreTrackBegin()
        {
            RoundSelect roundSelect = new RoundSelect();

            roundSelect.Show();
        }

        public void gameScoreTrackWin()
        {
            if (redPlayerScore == yellowPlayerScore)
            {
                // Draw between Red Player and Yellow Player
            }
            else if (redPlayerScore > (roundTotal / 2))
            {
                // Red Player wins current game
            }
            else if (yellowPlayerScore > (roundTotal / 2))
            {
                // Yellow Player wins current game
            }
            else
            {
                // No win or draw conditions met
            }
        }
    }
}