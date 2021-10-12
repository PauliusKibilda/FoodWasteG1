using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;



namespace FoodWaste
{

    public partial class RegisterPage : Form
    {
        private string Role;
        public RegisterPage(string role)
        {
            Role = role;
            InitializeComponent();
            this.CenterToScreen();
            usernameWarningLabel.Visible = false;
            emailWarningLabel.Visible = false;
            passwordWarningLabel.Visible = false;
            passwordsMatchWarningLabel.Visible = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Check if username field is empty

            if (!RegisterPageValidation.ValidateUserName(usernameTextBox.Text))
            {
                usernameWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                usernameWarningLabel.Visible = true;
            }
            else usernameWarningLabel.Visible = false;

            // Check if email field is empty
            if (!RegisterPageValidation.ValidateEmailAddress(emailTextBox.Text))
            {
                emailWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                emailWarningLabel.Visible = true;
            }
            else emailWarningLabel.Visible = false;

            // Check if password field is empty
            if (!RegisterPageValidation.ValidatePassword(passwordTextBox.Text))
            {
                passwordWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                passwordWarningLabel.Visible = true;
            }
            else passwordWarningLabel.Visible = false;

            // Check if passwords match
            if (!RegisterPageValidation.IsPasswordSame(passwordTextBox.Text, passwordConfirmTextbox.Text))
            {
                passwordsMatchWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                passwordsMatchWarningLabel.Visible = true;
            }
            else passwordsMatchWarningLabel.Visible = false;
            

            // Check if there are no warnings
            if (!(usernameWarningLabel.Visible || emailWarningLabel.Visible || passwordWarningLabel.Visible || passwordsMatchWarningLabel.Visible))
            {
                // Sign up succesfull
                // Add a user to the system

                string passwordHash = Hash.GetHashString(passwordTextBox.Text);
                if (String.IsNullOrWhiteSpace(phoneTextBox.Text))
                {
                    FileManager.InsertUser(usernameTextBox.Text, emailTextBox.Text, passwordHash, Role);
                }
                else
                {
                    FileManager.InsertUser(usernameTextBox.Text, emailTextBox.Text, passwordHash, phoneTextBox.Text, Role);
                }
                MessageBox.Show("User " + usernameTextBox.Text + " registered succesfully.");

            }

        }

        private void RegisterPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToLoginPage();
        }

        private void BackToLoginPage()
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
        }



    }
}
