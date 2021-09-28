using System;
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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            usernameWarningLabel.Visible = false;
            emailWarningLabel.Visible = false;
            passwordWarningLabel.Visible = false;
            passwordsMatchWarningLabel.Visible = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Check if username field is empty
            usernameWarningLabel.Visible = String.IsNullOrWhiteSpace(usernameTextBox.Text);

            // Check if email field is empty
            emailWarningLabel.Visible = String.IsNullOrWhiteSpace(emailTextBox.Text);

            // Check if password field is empty
            passwordWarningLabel.Visible = String.IsNullOrWhiteSpace(passwordTextBox.Text);

            // Check if passwords match
            passwordsMatchWarningLabel.Visible = passwordTextBox.Text != passwordConfirmTextbox.Text;
            
            // Check if there are no warnings
            if (!(usernameWarningLabel.Visible || emailWarningLabel.Visible || passwordWarningLabel.Visible || passwordsMatchWarningLabel.Visible))
            {
                // Sign up succesfull
                // Add a user to the system

                if (String.IsNullOrWhiteSpace(phoneTextBox.Text))
                {
                    User.RegisterUser(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
                }
                else
                {
                    User.RegisterUser(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, phoneTextBox.Text);
                }
            }
        }

        private void RegisterPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
        }
    }
}
