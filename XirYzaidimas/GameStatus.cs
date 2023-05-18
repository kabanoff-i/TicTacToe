using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class GameStatus: IGameStatus
    {
        Board board;
        Form1 form;
        public void Win(string Xor0)
        {
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                for (int j = 0; j < board.button.GetLength(0); j++)
                {
                    if (board.button[i, j].Text == Xor0)
                    {
                        board.button[i, j].BackColor = Color.FromArgb(0, 255, 0);
                    }
                    if (board.button[i, j].Text != Xor0)
                    {
                        board.button[i, j].BackColor = Color.FromArgb(128, 0, 0);
                    }
                    if (board.button[i, j].Text == "")
                    {
                        board.button[i, j].BackColor = Color.FromArgb(0, 0, 0);
                    }

                }
            }
            board.IsWinner = true;
            DialogResult result = MessageBox.Show(Xor0 + " Выиграл. Сыграть заново?", "", MessageBoxButtons.YesNo);

            if (Convert.ToString(result) == "Yes")
            {
                Start frmStart = new Start();
                form.Hide();
                frmStart.Closed += (s, args) => form.Close();
                frmStart.Show();
            }
            else
            {
                form.Close();
            }
        }

        public void CheckerRow(int j, string Xor0)
        {
            int num = 0;

            bool flag = true;

            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[i, j].Text == Xor0 && flag == true)
                {
                    num++;
                    if (num == board.button.GetLength(0))
                    {
                        Win(Xor0);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void CheckerColumn(int j, string Xor0)
        {
            int num = 0;
            bool flag = true;

            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[j, i].Text == Xor0 && flag == true)
                {
                    num++;
                    if (num == board.button.GetLength(0))
                    {
                        Win(Xor0);
                    }
                }
                else
                {
                    break;
                }
            }

        }

        public void CheckerDiagonalLeftToRight(string Xor0)
        {
            int num = 0;
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[i, i].Text == Xor0)
                    num++;
            }
            if (board.button.GetLength(0) == num)
            {
                Win(Xor0);
                return;
            }
        }

        public void CheckerDiagonalRightToLeft(string Xor0)
        {
            int num = 0;
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[i, board.button.GetLength(0) - i - 1].Text == Xor0)
                    num++;
            }
            if (board.button.GetLength(0) == num)
            {
                Win(Xor0);
                return;
            }

        }
        public void Checker()
        {
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                CheckerRow(i, "X");
                CheckerRow(i, "0");

                CheckerColumn(i, "X");
                CheckerColumn(i, "0");
            }
            CheckerDiagonalLeftToRight("X");
            CheckerDiagonalLeftToRight("0");

            CheckerDiagonalRightToLeft("X");
            CheckerDiagonalRightToLeft("0");

            if (board.stepsDone == board.button.Length)
            {
                board.IsWinner = true;
                DialogResult result = MessageBox.Show("Ничья. Сыграть заново?", "", MessageBoxButtons.YesNo);

                if (Convert.ToString(result) == "Yes")
                {
                    Start frmStart = new Start();
                    form.Hide();
                    frmStart.Closed += (s, args) => form.Close();
                    frmStart.Show();
                }
                else
                {
                    form.Close();
                }
            }
        }
        public void On()
        {
            board.Check += new CheckEventHandler(Checker);
        }
        public void Of()
        {
            board.Check -= new CheckEventHandler(Checker);
        }
        public GameStatus(Board board, Form1 form)
        {
            this.form = form;
            this.board = board;
            On();
        }
    }
}
