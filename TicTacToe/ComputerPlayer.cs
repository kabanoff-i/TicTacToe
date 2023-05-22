using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class ComputerPlayer: IPlayer
    {
        Board board;
        public void MakeAMove()
        {
            Random r = new Random();
            int row;
            int column;
            bool moveDone = false;
            do
            {
                row = r.Next(board.button.GetLength(0));
                column = r.Next(board.button.GetLength(0));
                if (board.IsValidMove(row, column, board.step) || board.stepsDone < 2)
                    if (board.button[row, column].Text == "")
                    {
                        board.button[row, column].Text = board.step;
                        board.stepsDone++;
                        // Поменять ход
                        if (board.step == "X")
                        {
                            board.step = "O";
                        }
                        else
                        {
                            board.step = "X";
                        }
                        board.OnCheck();// зажигаю событие проверки
                        moveDone = true;
                        break;
                    }
            } while (!moveDone);
        }
        public ComputerPlayer(Board board)
        {
            this.board = board;
        }
    }
}
