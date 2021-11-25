using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourApp
{
    public partial class ConnectFourBoard : Form
    {
        Button hoveredBtn = new Button();
        static Image whiteImg = new Bitmap(Image.FromFile("WhiteChecker.png"));
        static Image yellowImg = new Bitmap(Image.FromFile("YellowChecker.png"));
        static Image redImg = new Bitmap(Image.FromFile("RedChecker.png"));
        Image white = (Image)(new Bitmap(whiteImg, new Size(101, 101)));
        Image yellow = (Image)(new Bitmap(yellowImg, new Size(101, 101)));
        Image red = (Image)(new Bitmap(redImg, new Size(101, 101)));
        static Board ConnectBoard = new Board(7,6);
        static Button[,] btnTable = new Button[ConnectBoard.SizeW, ConnectBoard.SizeH];
        bool turn = true;
        bool winner = false;
        bool draw = false;
        Button prevButton;

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
            //this.Size = new Size(1000, 900);
        }
        private void TableBtnClick(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            Cell thisCell = new Cell(clickedBtn.Location.X, clickedBtn.Location.Y);

            if(clickedBtn.BackgroundImage == white && winner == false && draw == false)
            {
                //if (turn)
                //{
                //    canPlace(thisCell, btnTable);
                //    clickedBtn.BackgroundImage = red;
                //    turn = false;
                //}else
                //{
                //    clickedBtn.BackgroundImage = yellow;
                //    turn = true;
                //}
                //Console.WriteLine(clickedBtn.Location.X + " " + clickedBtn.Location.Y);
                canPlace(clickedBtn.Location.X, btnTable);
            }
        }
        private void isWinner(int x, int y, Button[,] btnTable, Image color)
        {
            /*int redC = 1;
            int yellowC=0;
            if(color == red)
            {
                ConnectBoard.table[x, y].isRed = true;
            }else if(color == yellow)
            {
                ConnectBoard.table[x, y].isYellow = true;
            }

            foreach (Cell cell in ConnectBoard.table)
            {
                if (cell.isRed == true)
                {
                    redC++;
                }
                else if (cell.isYellow == true)
                {
                    yellowC++;
                }
            }
            */
            //Console.WriteLine("red is " + redC);
            //Console.WriteLine("yellow is " + yellowC);
        }
        private void canPlace(int x, Button[,] btnTable) { 
            Image putImg = white;
            int y = -1;
            if (turn)
            {
                putImg = red;
                turn = false;
            } else
            {
                putImg = yellow;
                turn = true;
            }

            //the location comes in with a diffrent number so this sets it to the correct number
            switch(x)
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
            //this put thes checker at the bottom
            if (btnTable[x, 5].BackgroundImage == white)
            {
                btnTable[x, 5].BackgroundImage = putImg;
                y = 5;
            }
            else if(btnTable[x, 4].BackgroundImage == white)
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
                isWinner(x, y, btnTable, putImg);
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {

        }

        private void btnMusicToggle_Click(object sender, EventArgs e)
        {

        }

        private void btnEffectsToggle_Click(object sender, EventArgs e)
        {

        }
    }
}
