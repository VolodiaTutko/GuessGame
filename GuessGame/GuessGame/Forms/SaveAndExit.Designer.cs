namespace GuessGame.Forms
{
    partial class SaveAndExit
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(263, 138);
            button1.Name = "button1";
            button1.Size = new Size(126, 44);
            button1.TabIndex = 0;
            button1.Text = "Так, вийти ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += saveExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 52);
            label1.Name = "label1";
            label1.Size = new Size(383, 21);
            label1.TabIndex = 1;
            label1.Text = "Ви справді хочете вийти та зберегти свій результат?";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(69, 138);
            button2.Name = "button2";
            button2.Size = new Size(167, 44);
            button2.TabIndex = 2;
            button2.Text = "Повернутись до гри";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ReturnToGame_Click;
            // 
            // SaveAndExit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 210);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "SaveAndExit";
            Text = "SaveAndExit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
    }
}