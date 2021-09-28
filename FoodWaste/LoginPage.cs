﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodWaste
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // This function will need to be implemented properly later
        public bool CheckLoginCredentials(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }

            return false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CheckLoginCredentials(usernameTextBox.Text, passwordTextBox.Text))
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.ShowDialog();
            }
            else
            {
                // Sign in failed
            }
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckbox.Checked;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Go back to the main page
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerPage = new RegisterPage();
            registerPage.ShowDialog();
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}