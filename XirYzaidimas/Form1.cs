using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Board board;
        public Form1(int X, int Y, string Xor0Start) 
        {
            InitializeComponent();
            board = new Board(X, Y, Xor0Start, panel1, this);
        }

    }
}
