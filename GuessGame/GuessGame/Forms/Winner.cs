using GuessGame.Data;
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
    public partial class Winner : Form
    {
        public Main main;
        public Winner(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void newGame_click(object sender, EventArgs e)
        {

            Main mainForm = new Main(main.username);
            mainForm.Show();
            this.Hide();
            main.Hide();
        }

        private void Exit_click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.Show();
            this.Hide();
        }

        private void records_click(object sender, EventArgs e)
        {
            Dictionary<string, int?> userScores = new Dictionary<string, int?>();
            using (var context = new AppDbContext())
            {

                var sortedUsers = context.Users
                                          .OrderByDescending(u => u.Score)
                                          .Select(u => new { u.Name, u.Score })
                                          .ToList();

                foreach (var user in sortedUsers)
                {
                    if (!userScores.ContainsKey(user.Name))
                    {
                        userScores.Add(user.Name, user.Score);
                    }
                }
            }
            Records recordFrom = new Records(userScores);
            recordFrom.ShowDialog();
            this.Hide();
        }
    }
}
