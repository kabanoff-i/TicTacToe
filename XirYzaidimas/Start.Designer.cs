namespace TicTacToe
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.comboBoxGameMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCompPlayer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tic-Tac-Toe";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(125, 64);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(31, 20);
            this.textBoxSize.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Размер поля";
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Location = new System.Drawing.Point(32, 197);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(32, 17);
            this.radioButtonX.TabIndex = 9;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "X";
            this.radioButtonX.UseVisualStyleBackColor = true;
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Location = new System.Drawing.Point(80, 197);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(33, 17);
            this.radioButtonY.TabIndex = 10;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "O";
            this.radioButtonY.UseVisualStyleBackColor = true;
            // 
            // comboBoxGameMode
            // 
            this.comboBoxGameMode.FormattingEnabled = true;
            this.comboBoxGameMode.Items.AddRange(new object[] {
            "Классический режим",
            "Игра на время"});
            this.comboBoxGameMode.Location = new System.Drawing.Point(32, 124);
            this.comboBoxGameMode.Name = "comboBoxGameMode";
            this.comboBoxGameMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGameMode.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выберите режим игры";
            // 
            // checkBoxCompPlayer
            // 
            this.checkBoxCompPlayer.AutoSize = true;
            this.checkBoxCompPlayer.Location = new System.Drawing.Point(32, 151);
            this.checkBoxCompPlayer.Name = "checkBoxCompPlayer";
            this.checkBoxCompPlayer.Size = new System.Drawing.Size(128, 17);
            this.checkBoxCompPlayer.TabIndex = 13;
            this.checkBoxCompPlayer.Text = "Игра с комьютером";
            this.checkBoxCompPlayer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите сторону ";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(199, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxCompPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGameMode);
            this.Controls.Add(this.radioButtonY);
            this.Controls.Add(this.radioButtonX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonX;
        private System.Windows.Forms.RadioButton radioButtonY;
        private System.Windows.Forms.ComboBox comboBoxGameMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxCompPlayer;
        private System.Windows.Forms.Label label4;
    }
}