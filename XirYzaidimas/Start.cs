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
    public partial class Start : Form
    {

        public static int size;
        public Start()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBoxTime.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSize.Text))
            {  
                size = Convert.ToInt32(textBoxSize.Text);
                if(radioButtonX.Checked)
                {
                    Start start = new Start();
                    Form1 frm1 = new Form1(size, "X", checkBoxCompPlayer.Checked, comboBoxGameMode.SelectedIndex, int.Parse(textBoxTime.Text), int.Parse(textBox1.Text));
                    this.Hide();

                    frm1.Closed += (s, args) => this.Close();

                    frm1.Show();
                }else
                if (radioButtonY.Checked)
                {
                    Form1 frm1 = new Form1(size,"O", checkBoxCompPlayer.Checked, comboBoxGameMode.SelectedIndex, int.Parse(textBoxTime.Text), int.Parse(textBox1.Text));
                    this.Hide();

                    frm1.Closed += (s, args) => this.Close();

                    frm1.Show();
                }
                else
                    MessageBox.Show("Выберите сторону");
            }
            else
            {
                MessageBox.Show("Заполните размер поля");
            }
        }

        private void comboBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGameMode.SelectedIndex == 1)
            {
                label5.Visible= true;
                label6.Visible= true;
                textBoxTime.Visible= true;
                textBox1.Visible= true;
            }
            else
            {
                label5.Visible= false;
                label6.Visible= false;
                    textBoxTime.Visible= false;
                textBox1.Visible= false;
            }
        }
    }
}
