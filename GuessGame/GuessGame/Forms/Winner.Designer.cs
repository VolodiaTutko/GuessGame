namespace GuessGame.Forms
{
    partial class Winner
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
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            Record = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(12, 127);
            button2.Name = "button2";
            button2.Size = new Size(167, 44);
            button2.TabIndex = 5;
            button2.Text = "Почати нову гру";
            button2.UseVisualStyleBackColor = false;
            button2.Click += newGame_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 51);
            label1.Name = "label1";
            label1.Size = new Size(339, 26);
            label1.TabIndex = 4;
            label1.Text = "Вітаємо! Ви відгадали усі 20 слів! ";
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(185, 127);
            button3.Name = "button3";
            button3.Size = new Size(126, 44);
            button3.TabIndex = 6;
            button3.Text = "Вийти ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Exit_click;
            // 
            // Record
            // 
            Record.BackColor = Color.MidnightBlue;
            Record.BackgroundImage = Properties.Resources.medal;
            Record.BackgroundImageLayout = ImageLayout.None;
            Record.Cursor = Cursors.Hand;
            Record.Font = new Font("Bodoni MT Black", 14.25F, FontStyle.Bold);
            Record.ForeColor = SystemColors.ButtonFace;
            Record.ImageAlign = ContentAlignment.MiddleRight;
            Record.Location = new Point(317, 127);
            Record.Name = "Record";
            Record.Size = new Size(150, 44);
            Record.TabIndex = 13;
            Record.Text = "Рекорди";
            Record.UseVisualStyleBackColor = false;
            Record.Click += records_click;
            // 
            // Winner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 207);
            Controls.Add(Record);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Winner";
            Text = "Winner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button3;
        private Button Record;
    }
}