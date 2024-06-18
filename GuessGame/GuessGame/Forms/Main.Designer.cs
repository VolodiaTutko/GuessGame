namespace GuessGame.Forms
{
    partial class Main
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
            panel1 = new Panel();
            DescriptionLabel = new Label();
            userLabel = new Label();
            scoreLabel = new Label();
            label2 = new Label();
            checkBut = new Button();
            exitBut = new Button();
            char1 = new TextBox();
            char0 = new TextBox();
            char2 = new TextBox();
            char3 = new TextBox();
            char4 = new TextBox();
            char5 = new TextBox();
            Record = new Button();
            timerLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.DescBack;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(DescriptionLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 93);
            panel1.TabIndex = 0;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.BackColor = Color.Transparent;
            DescriptionLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DescriptionLabel.ForeColor = SystemColors.ButtonFace;
            DescriptionLabel.Location = new Point(80, 19);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(644, 52);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.BorderStyle = BorderStyle.Fixed3D;
            userLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold);
            userLabel.ForeColor = SystemColors.ButtonHighlight;
            userLabel.Location = new Point(26, 114);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(109, 32);
            userLabel.TabIndex = 1;
            userLabel.Text = "Володя";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.BorderStyle = BorderStyle.Fixed3D;
            scoreLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold);
            scoreLabel.ForeColor = SystemColors.ButtonHighlight;
            scoreLabel.Location = new Point(337, 114);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(27, 32);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(206, 114);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 2;
            label2.Text = "Рахунок:";
            label2.Click += label2_Click;
            // 
            // checkBut
            // 
            checkBut.BackColor = Color.SeaGreen;
            checkBut.Cursor = Cursors.Hand;
            checkBut.Font = new Font("Bodoni MT Black", 14.25F, FontStyle.Bold);
            checkBut.ForeColor = SystemColors.ButtonFace;
            checkBut.Location = new Point(460, 416);
            checkBut.Name = "checkBut";
            checkBut.Size = new Size(141, 38);
            checkBut.TabIndex = 4;
            checkBut.Text = "Перевірити";
            checkBut.UseVisualStyleBackColor = false;
            checkBut.Click += checkBut_Click;
            // 
            // exitBut
            // 
            exitBut.BackColor = Color.CadetBlue;
            exitBut.Cursor = Cursors.Hand;
            exitBut.Font = new Font("Bodoni MT Black", 14.25F, FontStyle.Bold);
            exitBut.ForeColor = SystemColors.ButtonFace;
            exitBut.Location = new Point(138, 416);
            exitBut.Name = "exitBut";
            exitBut.Size = new Size(188, 38);
            exitBut.TabIndex = 5;
            exitBut.Text = "Зберегти та вийти";
            exitBut.UseVisualStyleBackColor = false;
            exitBut.Click += exitBut_Click;
            // 
            // char1
            // 
            char1.Font = new Font("Broadway", 36F, FontStyle.Bold);
            char1.Location = new Point(221, 275);
            char1.Multiline = true;
            char1.Name = "char1";
            char1.Size = new Size(60, 56);
            char1.TabIndex = 6;
            char1.TextAlign = HorizontalAlignment.Center;
            // 
            // char0
            // 
            char0.Font = new Font("Broadway", 36F, FontStyle.Bold);
            char0.Location = new Point(138, 275);
            char0.Multiline = true;
            char0.Name = "char0";
            char0.Size = new Size(60, 56);
            char0.TabIndex = 7;
            char0.TextAlign = HorizontalAlignment.Center;
            // 
            // char2
            // 
            char2.Font = new Font("Broadway", 36F, FontStyle.Bold);
            char2.Location = new Point(304, 275);
            char2.Multiline = true;
            char2.Name = "char2";
            char2.Size = new Size(60, 56);
            char2.TabIndex = 8;
            char2.TextAlign = HorizontalAlignment.Center;
            // 
            // char3
            // 
            char3.Font = new Font("Broadway", 36F, FontStyle.Bold);
            char3.Location = new Point(386, 275);
            char3.Multiline = true;
            char3.Name = "char3";
            char3.Size = new Size(60, 56);
            char3.TabIndex = 9;
            char3.TextAlign = HorizontalAlignment.Center;
            // 
            // char4
            // 
            char4.Font = new Font("Broadway", 36F, FontStyle.Bold);
            char4.Location = new Point(464, 275);
            char4.Multiline = true;
            char4.Name = "char4";
            char4.Size = new Size(60, 56);
            char4.TabIndex = 10;
            char4.TextAlign = HorizontalAlignment.Center;
            // 
            // char5
            // 
            char5.Font = new Font("Broadway", 36F, FontStyle.Bold);
            char5.Location = new Point(541, 275);
            char5.Multiline = true;
            char5.Name = "char5";
            char5.Size = new Size(60, 56);
            char5.TabIndex = 11;
            char5.TextAlign = HorizontalAlignment.Center;
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
            Record.Location = new Point(206, 162);
            Record.Name = "Record";
            Record.Size = new Size(158, 44);
            Record.TabIndex = 12;
            Record.Text = "Рекорди";
            Record.UseVisualStyleBackColor = false;
            Record.Click += Record_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.BorderStyle = BorderStyle.Fixed3D;
            timerLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = SystemColors.ButtonHighlight;
            timerLabel.Location = new Point(669, 114);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(90, 39);
            timerLabel.TabIndex = 13;
            timerLabel.Text = "00:00";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 502);
            Controls.Add(timerLabel);
            Controls.Add(Record);
            Controls.Add(char5);
            Controls.Add(char4);
            Controls.Add(char3);
            Controls.Add(char2);
            Controls.Add(char0);
            Controls.Add(char1);
            Controls.Add(exitBut);
            Controls.Add(checkBut);
            Controls.Add(label2);
            Controls.Add(scoreLabel);
            Controls.Add(userLabel);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label DescriptionLabel;
        private Label userLabel;
        private Label scoreLabel;
        private Label label2;
        private Button checkBut;
        private Button exitBut;
        private TextBox char1;
        private TextBox char0;
        private TextBox char2;
        private TextBox char3;
        private TextBox char4;
        private TextBox char5;
        private Button Record;
        private Label timerLabel;
    }
}