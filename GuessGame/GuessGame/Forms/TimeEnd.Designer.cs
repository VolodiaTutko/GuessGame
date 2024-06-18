namespace GuessGame.Forms
{
    partial class TimeEnd
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
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(111, 148);
            button3.Name = "button3";
            button3.Size = new Size(126, 44);
            button3.TabIndex = 9;
            button3.Text = "Вийти ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += exit_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(280, 148);
            button2.Name = "button2";
            button2.Size = new Size(167, 44);
            button2.TabIndex = 8;
            button2.Text = "Почати нову гру";
            button2.UseVisualStyleBackColor = false;
            button2.Click += startNewGame_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 40);
            label1.Name = "label1";
            label1.Size = new Size(379, 41);
            label1.TabIndex = 7;
            label1.Text = "На жаль час 5 хв. уже пройшов!";
           
            // 
            // label2
            // 
            label2.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 81);
            label2.Name = "label2";
            label2.Size = new Size(459, 34);
            label2.TabIndex = 10;
            label2.Text = "Гра завершена та результат збережено!";
            // 
            // TimeEnd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 266);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "TimeEnd";
            Text = "TimeEnd";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}