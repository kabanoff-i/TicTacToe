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
        Button[,] button;

        string step;

        public static int board;
        public static int stepsDone = 0;
        public static int orientX;
        public static int orientY;
        public static string Xor0Sender;

        public Form1(int X, int Y, string Xor0Start) 
        {
            orientX = X;
            orientY = Y;
            Xor0Sender = Xor0Start;
            board = orientX * orientY;
            step = Xor0Sender;

            InitializeComponent();
            button = new Button[X, Y];

            int uniqueTag = 0; // для присвоения уникального кода
      

            for (int i = 0; i < X; i++)
            {
                for(int j = 0; j < Y; j++)
                {
                    button[i, j] = new Button(); // каждая кнопка инициализируется
                    button[i, j].Parent = panel1; // Рендеринг
                    button[i, j].Width = panel1.Width / X; // настройки рендеринга
                    button[i, j].Height = panel1.Height / X;

                    button[i, j].Top = j*panel1.Height / X; // кнопки на 100% ширины окна
                    button[i, j].Left= i*panel1.Width / X; 
                    button[i, j].Click += new EventHandler(onclick);// добавление обработчика события
                    button[i, j].Tag = uniqueTag; // присвоение каждому уникального кода

                    int newSize = 22;
                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, newSize, FontStyle.Bold);

                    uniqueTag++;
                }
            }
        }

        //Окрашивание поля в случае победы
        private void win(string Xor0)
        {
            for (int i = 0; i < orientX; i++)
            {
                for (int j = 0; j < orientY; j++)
                {
                    if (button[i, j].Text == Xor0)
                    {
                        button[i, j].BackColor = Color.FromArgb(0, 255, 0); 
                    }
                    if (button[i, j].Text != Xor0)
                    {
                        button[i, j].BackColor = Color.FromArgb(128, 0, 0); 
                    }
                    if (button[i, j].Text == "")
                    {
                        button[i, j].BackColor = Color.FromArgb(0, 0, 0); 
                    }

                }
            }
            DialogResult result = MessageBox.Show(Xor0 + " Выиграл. Сыграть заново?", "", MessageBoxButtons.YesNo);

            if(Convert.ToString(result) == "Yes")
            {
                Start frmStart = new Start();
                this.Hide();
                frmStart.Closed += (s, args) => this.Close();
                frmStart.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void checkerRow(int j, string Xor0)
        {
            int num = 0;

            bool flag = true; 

            for (int i = 0; i < orientX ; i++) 
            {
                if (button[i, j].Text == Xor0 && flag == true)
                {
                    num++;
                    if(num == orientX)
                    {
                        win(Xor0);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void checkerColumn( int j, string Xor0)
        {
            int num = 0;
            bool flag = true; 

            for (int i = 0; i < orientX; i++) 
            {
                if (button[j, i].Text == Xor0 && flag == true)
                {
                    num++;
                    if (num == orientX)
                    {
                        win(Xor0);
                    }
                }
                else
                {
                    break;
                }
            }

        }

        public void checkerDiagonalLeftToRight(string Xor0)
        {
            int num = 0;
            for (int i = 0; i < orientX; i++)
            {
                if (button[i, i].Text == Xor0)
                    num++;
            }
            if (orientX == num)
            { 
                win(Xor0);
                return;
            }
        }

        private void checkerDiagonalRightToLeft(string Xor0)
        {
            int num = 0;
            for (int i = 0; i < orientX; i++)
            {
                if (button[i, orientX - i -1].Text == Xor0)
                    num++;
            }
            if (orientX == num)
            {
                win(Xor0);
                return;
            }

        }
        private void checker()
        {
           
            for (int i = 0; i < orientX; i++)
            {
                checkerRow(i, "X");
                checkerRow(i, "0");
                    
                checkerColumn(i, "X");
                checkerColumn(i, "0");
            }
            checkerDiagonalLeftToRight("X");
            checkerDiagonalLeftToRight("0");

            checkerDiagonalRightToLeft("X");
            checkerDiagonalRightToLeft("0");

            if (stepsDone == board)
            {
                DialogResult result = MessageBox.Show("Ничья. Сыграть заново?", "", MessageBoxButtons.YesNo);

                if (Convert.ToString(result) == "Yes")
                {
                    Start frmStart = new Start();
                    this.Hide();
                    frmStart.Closed += (s, args) => this.Close();
                    frmStart.Show();
                }
                else
                {
                    this.Close();
                }

            }
        }

        private void onclick(object sender, EventArgs e)
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
                checker();
            }
            else
                MessageBox.Show("Выберите свободное поле");
        }
    }
}
