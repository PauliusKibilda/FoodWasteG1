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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // This function will need to be implemented properly later
        public bool checkLoginCredentials(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }

            return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (checkLoginCredentials(usernameTextBox.Text, passwordTextBox.Text))
            {
                // Sign in succeded
            }
            else
            {
                // Sign in failed
            }
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Go back to the main page
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // Go to sign up screen
        }
    }
}
