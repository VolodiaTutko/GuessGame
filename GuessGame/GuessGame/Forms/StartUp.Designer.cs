namespace GuessGame.Forms
{
    partial class StartUp
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
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxPassword = new TextBox();
            startGamebutton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumBlue;
            label2.Font = new Font("Playbill", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(282, 18);
            label2.Name = "label2";
            label2.Size = new Size(236, 29);
            label2.TabIndex = 1;
            label2.Text = "\"ВГАДАЙ СЛОВО\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Playbill", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(127, 94);
            label1.Name = "label1";
            label1.Size = new Size(583, 29);
            label1.TabIndex = 2;
            label1.Text = "Для початку гри введіть своє ім'я та пароль";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.DarkGray;
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(225, 184);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(340, 30);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Playbill", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(355, 228);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 4;
            label3.Text = "Пароль :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Playbill", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(372, 152);
            label4.Name = "label4";
            label4.Size = new Size(76, 29);
            label4.TabIndex = 5;
            label4.Text = "Ім'я :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.DarkGray;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(225, 260);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(340, 30);
            textBoxPassword.TabIndex = 6;
            // 
            // startGamebutton
            // 
            startGamebutton.BackColor = Color.Green;
            startGamebutton.Cursor = Cursors.Hand;
            startGamebutton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGamebutton.ForeColor = SystemColors.Control;
            startGamebutton.Location = new Point(561, 351);
            startGamebutton.Name = "startGamebutton";
            startGamebutton.Size = new Size(149, 39);
            startGamebutton.TabIndex = 7;
            startGamebutton.Text = "Почати гру";
            startGamebutton.UseVisualStyleBackColor = false;
            startGamebutton.Click += startGamebutton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.DarkRed;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(372, 351);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(149, 39);
            exitButton.TabIndex = 8;
            exitButton.Text = "Вийти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(startGamebutton);
            Controls.Add(textBoxPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StartUp";
            Text = "StartUp";
            Load += StartUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private Label label3;
        private Label label4;
        private TextBox textBoxPassword;
        private Button startGamebutton;
        private Button exitButton;
    }
}