using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame.Forms
{
    public partial class Records : Form
    {

        public Dictionary<string, int?> UserScores;
        public Records(Dictionary<string, int?> userScores)
        {
            InitializeComponent();

            UserScores = userScores;

            RecordTable.Columns.Clear();
            RecordTable.Columns.Add("Username", "Username");
            RecordTable.Columns.Add("Score", "Score");

            
            foreach (var user in UserScores)
            {
                RecordTable.Rows.Add(user.Key.ToString(), user.Value.ToString());
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.Show();
            this.Hide();
        }

        
    }
}
