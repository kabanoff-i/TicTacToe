using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class GameStatusTime: IGameStatus
    {
        protected Board board;
        protected Form1 form;
        public int pointsX;
        public int points0;
        public int length;
        public void Win(string Xor0)
        {
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                for (int j = 0; j < board.button.GetLength(0); j++)
                {
                    if (Xor0 == "Ничья")
                        board.button[i, j].BackColor = Color.FromArgb(200, 200, 200);
                    else
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
                            board.button[i, j].BackColor = Color.FromArgb(200, 200, 200);
                        }
                    }
                }
            }
            board.IsWinner = true;
            form.TimerStop();

            DialogResult result = MessageBox.Show($"Очки X: {pointsX}\nОчки O: {points0}\nПобедитель {Xor0}\nСыграть заново?", "", MessageBoxButtons.YesNo);

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

            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[i, j].Text == Xor0)
                {
                    num++;
                    if (num == length)
                    {
                        if (Xor0 == "X")
                            pointsX++;
                        else
                            if (Xor0 == "O")
                                points0++;
                    }
                }
                else
                {
                    num = 0;
                }
            }
        }

        public void CheckerColumn(int j, string Xor0)
        {
            int num = 0;

            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[j, i].Text == Xor0)
                {
                    num++;
                    if (num == length)
                    {
                        if (Xor0 == "X")
                            pointsX++;
                        else
                            if (Xor0 == "O")
                            points0++;
                    }
                }
                else
                {
                    num = 0;
                }
            }
        }

        public void CheckerDiagonalLeftToRight(string Xor0)
        {
            int num = 0;
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[i, i].Text == Xor0)
                {
                    num++;
                    if (num == length)
                    {
                        if (Xor0 == "X")
                            pointsX++;
                        else
                            if (Xor0 == "O")
                                points0++;
                    }
                }
                else
                { num = 0; }
            }
        }

        public void CheckerDiagonalRightToLeft(string Xor0)
        {
            int num = 0;
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                if (board.button[i, board.button.GetLength(0) - i - 1].Text == Xor0)
                {
                    num++;
                    if (num == length)
                    {
                        if (Xor0 == "X")
                            pointsX++;
                        else
                           if (Xor0 == "O")
                            points0++;
                    }
                }
                else
                { num = 0; }
            }
        }
        public void Checker()
        {
            for (int i = 0; i < board.button.GetLength(0); i++)
            {
                CheckerRow(i, "X");
                CheckerRow(i, "O");

                CheckerColumn(i, "X");
                CheckerColumn(i, "O");
            }
            CheckerDiagonalLeftToRight("X");
            CheckerDiagonalLeftToRight("O");

            CheckerDiagonalRightToLeft("X");
            CheckerDiagonalRightToLeft("O");

            string winner = "Ничья";
            if (pointsX > points0)
                winner = "X";
            else
                if (pointsX < points0)
                    winner = "O";
            Win(winner);
        }
        public void On()
        {
            board.Check += new CheckEventHandler(Checker);
        }
        public void Of()
        {
            board.Check -= new CheckEventHandler(Checker);
        }

        public GameStatusTime(Board board, Form1 form, int lineLength)
        {
            this.form = form;
            this.board = board;
            On();
            length = lineLength;
            form.TimeOut += Checker;
        }
    }
}