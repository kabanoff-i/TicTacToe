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
    public delegate void TimeOutEventHandler();
    public partial class Form1 : Form
    {
        Board board;
        private int remainingTime; // Изначальное значение обратного отсчета
        public event TimeOutEventHandler TimeOut;
        public Form1(int size, string Xor0Start, bool IsCompPlayer, int GameMode, int time, int length) 
        {
            InitializeComponent();
            
            label1.Visible = false;
            label2.Visible = false;
            remainingTime = time;
            label1.Text = remainingTime.ToString();
            timer.Tick += Timer1_Tick;
            if (GameMode == 1)
            {
                label1.Visible = true;
                label2.Visible = true;
                timer.Interval= 1000;
                timer.Start();
            }
            board = new Board(size, Xor0Start, IsCompPlayer, panel1, this, GameMode, length);
        }
        private void OnTimeOut()
        {
            if (TimeOut != null)
                TimeOut();
        }
        public void TimerStop()
        {
            timer.Stop();
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
                OnTimeOut();
            }
        }

    }
}
