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
    public partial class TimeEnd : Form
    {

        public Main main;
        public TimeEnd(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

       
        private void startNewGame_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main(main.username);
            mainForm.Show();
            this.Hide();
            main.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.Show();
            this.Hide();
        }
    }
}
