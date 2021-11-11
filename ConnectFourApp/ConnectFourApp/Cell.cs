using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourApp
{
    class Cell
    {
        public int row { get; set; }
        public int column { get; set; }

        public bool isRed { get; set; }
        public bool isYellow { get; set; }

        public Cell(int x, int y)
        {
            row = x;
            column = y;
        }
    }
}
