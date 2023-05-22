using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public delegate void CheckEventHandler();
    public class Board : AbstractBoard
    {
        public event CheckEventHandler Check;

        Form1 form;
        ComputerPlayer player;
        bool IsCompPlayer;
        public bool IsWinner;
        int Mode;
        int length;
        GameStatusTime gameStatusTime;

        public void OnCheck()
        {
            if (Mode == 0)
            {
                GameStatus gameStatus = new GameStatus(this, form);
                if (Check != null)
                {
                    Check();
                    gameStatus.Of();
                }
            }
            else
            if (Check != null && stepsDone == button.Length)
            {
                Check();
                gameStatusTime.Of();
            }
        }
        void OnClick(object sender, EventArgs e)
        {
            try
            {
                // Заполнить клетку
                Button b = (Button)sender;
                Tuple<int, int> targetButton = FindButton(b);
                if (IsValidMove(targetButton.Item1, targetButton.Item2, step) || stepsDone < 2)
                {
                    if (b.Text == "")
                    {
                        b.Text = step;
                        stepsDone++;
                        // Поменять ход
                        if (step == "X")
                        {
                            step = "O";
                        }
                        else
                        {
                            step = "X";
                        }
                        OnCheck();// зажигаю событие проверки
                        if (IsCompPlayer && !IsWinner)
                        {
                            player.MakeAMove();
                        }
                    }
                    else
                        throw new FilledCellException("Выберите свободное поле");
                }
                else
                    throw new OutOf5RangeCellsException("Выберите поле в пределах 5 ячеек от уже заполненной вашим ходом");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Tuple<int, int> FindButton(Button targetButton)
        {
            for (int i = 0; i < button.GetLength(0); i++)
            {
                for (int j = 0; j < button.GetLength(1); j++)
                {
                    if (button[i, j].Equals(targetButton))
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return null;
        }
        public bool IsValidMove(int rowIndex, int columnIndex, string symbol)
        {
            // Проверка всех направлений от выбранной кнопки
            for (int i = rowIndex - 5; i <= rowIndex + 5; i++)
            {
                for (int j = columnIndex - 5; j <= columnIndex + 5; j++)
                {
                    // Проверка границ массива
                    if (i >= 0 && i < button.GetLength(0) && j >= 0 && j < button.GetLength(1))
                    {
                        // Проверка наличия отмеченной кнопки с тем же символом
                        if (button[i, j].Text == symbol)
                        {
                            // Проверка расстояния до отмеченной кнопки
                            int distance = Math.Abs(rowIndex - i) + Math.Abs(columnIndex - j);
                            if (distance <= 5)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

            public Board(int size, string Xor0Start,bool IsCompPlayer, Panel panel1, Form1 form, int gamemode, int length)
        {
            this.form = form;
            button = new Button[size, size];
            step = Xor0Start;
            this.IsCompPlayer = IsCompPlayer;
            Mode = gamemode;
            this.length = length;

            if (gamemode == 1)
                gameStatusTime = new GameStatusTime(this, form, length);
            if (IsCompPlayer)
                player = new ComputerPlayer(this);
            IsWinner = false;

            int uniqueTag = 0; // для присвоения уникального кода
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    button[i, j] = new Button(); // каждая кнопка инициализируется
                    button[i, j].Parent = panel1; // Рендеринг
                    button[i, j].Width = panel1.Width / size; // настройки рендеринга
                    button[i, j].Height = panel1.Height / size;

                    button[i, j].Top = j * panel1.Height / size; // кнопки на 100% ширины окна
                    button[i, j].Left = i * panel1.Width / size;
                    button[i, j].Click += new EventHandler(OnClick);// добавление обработчика события
                    button[i, j].Tag = uniqueTag; // присвоение каждому уникального кода

                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, button[i,j].Height/2 - 1, FontStyle.Bold);

                    uniqueTag++;
                }
            }
        }
    }
}
