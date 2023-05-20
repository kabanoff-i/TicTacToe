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
        private int remainingTime; // Изначальное значение обратного отсчета
        public Form1(int size, string Xor0Start, bool IsCompPlayer, int GameMode, int time, int length) 
        {
            InitializeComponent();
            
            remainingTime = time;
            label1.Text = remainingTime.ToString();
            timer.Tick += Timer1_Tick;
            if (GameMode == 1)
            {
                timer.Interval= 1000;
                timer.Start();
            }
            board = new Board(size, Xor0Start, IsCompPlayer, panel1, this, GameMode);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Уменьшаем значение обратного отсчета
            remainingTime--;

            // Обновляем значение метки с использованием оставшегося времени
            label1.Text = remainingTime.ToString();

            // Проверяем, если обратный отсчет достиг нуля, останавливаем таймер
            if (remainingTime == 0)
            {
                timer.Stop();
                MessageBox.Show("Обратный отсчет завершен!");
            }
        }

    }
}
