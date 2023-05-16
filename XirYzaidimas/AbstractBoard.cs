using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public abstract class AbstractBoard
    {

        public Button[,] button;

        public string step;

        public int stepsDone = 0;
        public string Xor0Sender;
    }
}
