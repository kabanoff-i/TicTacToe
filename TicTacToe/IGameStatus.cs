using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public interface IGameStatus
    {
        void CheckerRow(int i, string a);
        void CheckerColumn(int i, string a);
        void CheckerDiagonalLeftToRight(string a);
        void CheckerDiagonalRightToLeft(string a);
        void Checker();
        void Win(string a);
    }
}
