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
            UsernameWarningLabel.Visible = false;
            EmailWarningLabel.Visible = false;
            PasswordWarningLabel.Visible = false;
            PasswordsMatchWarningLabel.Visible = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Validate Username
            if (!UsernameTextBox.Text.IsValidUsername())
            {
                UsernameWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                UsernameWarningLabel.Visible = true;
            }
            else UsernameWarningLabel.Visible = false;

            // Validate Email
            if (!EmailTextBox.Text.IsValidEmailAddress())
            {
                EmailWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                EmailWarningLabel.Visible = true;
            }
            else EmailWarningLabel.Visible = false;

            // Validate Password
            if (!PasswordTextBox.Text.IsValidPassword())
            {
                PasswordWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                PasswordWarningLabel.Visible = true;
            }
            else PasswordWarningLabel.Visible = false;

            // Check if passwords match
            if (!RegisterPageValidation.IsPasswordSame(PasswordTextBox.Text, PasswordConfirmTextbox.Text))
            {
                PasswordsMatchWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                PasswordsMatchWarningLabel.Visible = true;
            }
            else PasswordsMatchWarningLabel.Visible = false;
            

            // Check if there are no warnings
            if (!(UsernameWarningLabel.Visible || EmailWarningLabel.Visible
               || PasswordWarningLabel.Visible || PasswordsMatchWarningLabel.Visible))
            {
                // Sign up succesfull
                // Add a user to the system

                string passwordHash = Hash.GetHashString(PasswordTextBox.Text);
                if (String.IsNullOrWhiteSpace(PhoneTextBox.Text))
                {
                    FileManager.InsertUser(UsernameTextBox.Text, EmailTextBox.Text, passwordHash, Role);
                }
                else
                {
                    FileManager.InsertUser(UsernameTextBox.Text, EmailTextBox.Text, passwordHash, PhoneTextBox.Text, Role);
                }
                MessageBox.Show("User " + UsernameTextBox.Text + " registered succesfully.");
                BackToLoginPage();

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
            this.Close();
        }
    }
}
