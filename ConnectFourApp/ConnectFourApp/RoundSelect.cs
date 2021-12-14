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
        // Create string values for combo box
        string[] oddRounds = new string[] { "1", "3", "5", "7", "9" };

        public RoundSelect()
        {
            InitializeComponent();
            comboBoxRoundSelect.Items.AddRange(oddRounds);
        }

        private void btnRoundSelect_MouseClick(object sender, MouseEventArgs e)
        {
            

        }
    }
}
