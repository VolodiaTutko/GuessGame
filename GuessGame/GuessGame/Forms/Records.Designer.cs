namespace GuessGame.Forms
{
    partial class Records
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
            label1 = new Label();
            button1 = new Button();
            RecordTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RecordTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("French Script MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(219, 31);
            label1.TabIndex = 0;
            label1.Text = "Список рекордів :";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(624, 378);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(144, 34);
            button1.TabIndex = 1;
            button1.Text = "Вийти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += exit_Click;
            // 
            // RecordTable
            // 
            RecordTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecordTable.Location = new Point(57, 64);
            RecordTable.Margin = new Padding(4, 3, 4, 3);
            RecordTable.Name = "RecordTable";
            RecordTable.Size = new Size(487, 296);
            RecordTable.TabIndex = 2;
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 435);
            Controls.Add(RecordTable);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Records";
            Text = "Records";
            ((System.ComponentModel.ISupportInitialize)RecordTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView RecordTable;
    }
}