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
    public partial class RoundSelect : Form
    {

        string[] oddRounds = new string[] { "1", "3", "5", "7", "9" };

        public RoundSelect()
        {
            InitializeComponent();
            comboBoxRoundSelect.Items.AddRange(oddRounds);
        }

        private void btnRoundSelect_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxRoundSelect.SelectedText == "3")
            {
                ConnectFourBoard.roundTotal = 3;
            }
            else if (comboBoxRoundSelect.SelectedText == "5")
            {
                ConnectFourBoard.roundTotal = 5;
            }
            else if (comboBoxRoundSelect.SelectedText == "7")
            {
                ConnectFourBoard.roundTotal = 7;
            }
            else if (comboBoxRoundSelect.SelectedText == "9")
            {
                ConnectFourBoard.roundTotal = 9;
            }
            else
            {
                ConnectFourBoard.roundTotal = 1;
            }
        }
    }
}
