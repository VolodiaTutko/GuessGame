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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GuessGame.Forms
{
    public partial class SaveAndExit : Form
    {
        public Main mainform;
        public SaveAndExit(Main mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void saveExit_Click(object sender, EventArgs e)
        {
            SaveScoreToDatabase();
            this.Hide();
            mainform.Hide();
            StartUp startUp = new StartUp();
            startUp.Show();
        }

        private void ReturnToGame_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveScoreToDatabase()
        {

            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == mainform.username);

                if (user != null)
                {

                    user.Score = mainform.score;


                    context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Користувач не знайдений в базі даних.");
                }
            }
        }

      
    }
}
