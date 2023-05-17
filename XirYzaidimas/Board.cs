using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public delegate void CheckEventHandler();
    public class Board : AbstractBoard
    {
        public event CheckEventHandler Check;

        Form1 form;
        IPlayer player1;
        IPlayer player2;

        public void OnCheck()
        {
            GameStatus gameStatus = new GameStatus(this, form);
            if (Check != null)
            {
                Check();
                gameStatus.Of();
            }
        }
        void OnClick(object sender, EventArgs e)
        {
            // Заполнить клетку
            Button b = (Button)sender;
            if (b.Text == "")
            {
                b.Text = step;
                stepsDone++;
                // Поменять ход
                if (step == "X")
                {
                    step = "0";
                }
                else
                {
                    step = "X";
                }
                OnCheck();// зажигаю событие проверки
            }
            else
                MessageBox.Show("Выберите свободное поле");
        }

        public Board(int X, int Y, string Xor0Start, Panel panel1, Form1 form)
        {
            this.form = form;
            button = new Button[X, Y];
            step = Xor0Start;

            player1 = new HumanPlayer(this);
            player2 = new HumanPlayer(this);

            int uniqueTag = 0; // для присвоения уникального кода
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    button[i, j] = new Button(); // каждая кнопка инициализируется
                    button[i, j].Parent = panel1; // Рендеринг
                    button[i, j].Width = panel1.Width / X; // настройки рендеринга
                    button[i, j].Height = panel1.Height / X;

                    button[i, j].Top = j * panel1.Height / X; // кнопки на 100% ширины окна
                    button[i, j].Left = i * panel1.Width / X;
                    button[i, j].Click += new EventHandler(OnClick);// добавление обработчика события
                    button[i, j].Tag = uniqueTag; // присвоение каждому уникального кода

                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, 22, FontStyle.Bold);

                    uniqueTag++;
                }
            }
        }
    }
}
