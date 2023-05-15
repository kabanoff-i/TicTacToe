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
            this.checkBoxForX = new System.Windows.Forms.CheckBox();
            this.checkBoxFor0 = new System.Windows.Forms.CheckBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxForX
            // 
            this.checkBoxForX.AutoSize = true;
            this.checkBoxForX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxForX.Location = new System.Drawing.Point(36, 119);
            this.checkBoxForX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxForX.Name = "checkBoxForX";
            this.checkBoxForX.Size = new System.Drawing.Size(33, 17);
            this.checkBoxForX.TabIndex = 0;
            this.checkBoxForX.Text = "X";
            this.checkBoxForX.UseVisualStyleBackColor = true;
            this.checkBoxForX.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxFor0
            // 
            this.checkBoxFor0.AutoSize = true;
            this.checkBoxFor0.Location = new System.Drawing.Point(101, 119);
            this.checkBoxFor0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFor0.Name = "checkBoxFor0";
            this.checkBoxFor0.Size = new System.Drawing.Size(32, 17);
            this.checkBoxFor0.TabIndex = 1;
            this.checkBoxFor0.Text = "0";
            this.checkBoxFor0.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(22, 68);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(53, 32);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(101, 68);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(55, 32);
            this.textBoxY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tic-Tac-Toe";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(190, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.checkBoxFor0);
            this.Controls.Add(this.checkBoxForX);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxForX;
        private System.Windows.Forms.CheckBox checkBoxFor0;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}