using GuessGame.Data;
using GuessGame.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Timer = System.Windows.Forms.Timer;

namespace GuessGame.Forms
{
    public partial class Main : Form
    {

        public int score = 0;
        public Word word;
        public string username;

        public List<int?> IdList = new List<int?>();

        public int totalTimeInSeconds = 300;

        public Timer timer;
        public Main(string userName)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Game_Controller;
            username = userName;
            userLabel.Text = username;           
            scoreLabel.Text = score.ToString();


            var db_ = new AppDbContext();            
            var WordList = db_.Words.ToList();

            foreach (var word in WordList)
            {
                IdList.Add(word.WordId);
            }

            Random random = new Random();

            int index = random.Next(IdList.Count);

           
            int? randomId = IdList[index];

            word = db_.Words.FirstOrDefault(w => w.WordId == randomId);

            IdList.Remove(randomId);

            FillDescription(word);
            FillTextBoxes(word);

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Enabled = true;
            timer.Tick += Timer_Tick; 

           
            UpdateTimerLabel();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
            totalTimeInSeconds--;

           
            if (totalTimeInSeconds <= 0)
            {
                
                SaveScoreToDatabase();

                timer.Stop();

                TimeEnd timeEndForm = new TimeEnd(this);
                timeEndForm.ShowDialog();   
               
            }

          
            UpdateTimerLabel();
        }
        private void SaveScoreToDatabase()
        {

            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == username);

                if (user != null)
                {

                    user.Score = score;


                    context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Користувач не знайдений в базі даних.");
                }
            }
        }
     

        private void UpdateTimerLabel()
        {
            
            int minutes = totalTimeInSeconds / 60;
            int seconds = totalTimeInSeconds % 60;

           
            timerLabel.Text = $" {minutes:D2}:{seconds:D2} "; 
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void FillDescription(Word word)
        {
            DescriptionLabel.Text = word.Description;
        }

        private void FillTextBoxes(Word word)
        {
            string wordValue = word.Value;
            char[] characters = wordValue.ToCharArray();
            char char1 = characters[1];
            char char2 = characters[3];
            char char3 = characters[4];

            this.char0.Text = "";
            this.char2.Text = "";
            this.char5.Text = "";


            this.char1.Text = char1.ToString();
            this.char3.Text = char2.ToString();
            this.char4.Text = char3.ToString();
        }


        private void checkBut_Click(object sender, EventArgs e)
        {

            string input = char0.Text + char1.Text + char2.Text +
                           char3.Text + char4.Text + char5.Text;


            if (input == word.Value)
            {
                score++;

                scoreLabel.Text = score.ToString();


                if (score == 20)
                {

                    timer.Stop();               
                    using (var context = new AppDbContext())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Name == username);

                        if (user != null)
                        {

                            user.Score = 20;


                            context.SaveChanges();

                        }
                        else
                        {
                            MessageBox.Show("Користувач не знайдений в базі даних.");
                        }
                    }

                    Winner winnerForm = new Winner(this);
                    winnerForm.ShowDialog();
                }
                else
                {
                    Random random = new Random();

                    int index = random.Next(IdList.Count);


                    int? randomId = IdList[index];
                   
                    int? nextId = word.WordId + 1;
                    using (var context = new AppDbContext())
                    {
                        var nextWord = context.Words.FirstOrDefault(w => w.WordId == randomId);
                        if (nextWord != null)
                        {
                            word = nextWord;
                            FillDescription(word);
                            FillTextBoxes(word);
                            IdList.Remove(randomId);
                        }
                        else
                        {
                            MessageBox.Show("Досягнуто останнє слово в грі.");

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Неправильне слово. Спробуйте ще раз.");
                FillDescription(word);
                FillTextBoxes(word);
            }
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
           
            SaveAndExit saveAndExit = new SaveAndExit(this);
            saveAndExit.ShowDialog();
            
        }

        private void Record_Click(object sender, EventArgs e)
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
           
        }
    }
}
