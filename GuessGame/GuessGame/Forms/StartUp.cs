using GuessGame.Data;
using GuessGame.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Game_Controller;
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void startGamebutton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть ім'я та пароль.");
                return;
            }


            bool userExists = CheckUserExists(name);

            if (userExists)
            {

                bool passwordCorrect = CheckPassword(name, password);
                if (passwordCorrect)
                {

                    Main mainForm = new Main(name);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль.");
                }
            }
            else
            {

                AddUser(name, password);


                Main mainForm = new Main(name);
                mainForm.Show();
                this.Hide();
            }
        }


        private bool CheckUserExists(string name)
        {
            bool exists = false;
            using (var context = new AppDbContext())
            {
                var users = context.Users.ToList();
                foreach (var user in users)
                {
                    if (user.Name == name)
                    {
                        exists = true;
                        break;
                    }
                }
            }
            return exists;
        }


        private bool CheckPassword(string name, string password)
        {
            bool correct = false;
            try
            {
                using (var context = new AppDbContext())
                {
                    var users = context.Users.ToList();
                    foreach (var user in users)
                    {
                        if (user.Name == name && user.Password == password)
                        {
                            correct = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при перевірці паролю: {ex.Message}");
            }
            return correct;
        }

        private void AddUser(string name, string password)
        {
            try
            {                using (var context = new AppDbContext())
                {
                    var user = new User
                    {
                        Name = name,
                        Password = password
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні користувача: {ex.Message}");
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
