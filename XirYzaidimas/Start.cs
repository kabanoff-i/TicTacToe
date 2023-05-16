﻿using System;
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
    public partial class Start : Form
    {

        public static int SetValueForX;
        public static int SetValueForY;
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxX.Text) && !string.IsNullOrWhiteSpace(textBoxY.Text))
            {  
            SetValueForX = Convert.ToInt32(textBoxX.Text);
            SetValueForY = Convert.ToInt32(textBoxY.Text);
                if (SetValueForX == SetValueForY)
                {
                    if(checkBoxForX.Checked && !checkBoxFor0.Checked)
                    {
                        Start start = new Start();
                        Form1 frm1 = new Form1(SetValueForX, SetValueForY, checkBoxForX.Text);
                        this.Hide();

                        frm1.Closed += (s, args) => this.Close();

                        frm1.Show();
                    }else
                    if (checkBoxFor0.Checked && !checkBoxForX.Checked)
                    {

                        Form1 frm1 = new Form1(SetValueForX, SetValueForY, checkBoxFor0.Text);
                        this.Hide();

                        frm1.Closed += (s, args) => this.Close();

                        frm1.Show();
                    }
                    else
                        MessageBox.Show("Choose your turn correctly");
                }
                else
                {
                    MessageBox.Show("We can't create Tic-Tac-Toe game for " + SetValueForX + "x" + SetValueForY + " table X-O");
                }
            }
            else
            {
                MessageBox.Show("Fill Values");
            }
        }
    }
}