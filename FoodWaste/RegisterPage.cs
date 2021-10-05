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
            shortUsernameWarningLabel.Visible = false;
            invalidUsernameWarningLabel.Visible = false;
            emailWarningLabel.Visible = false;
            invalidEmailAddressWarningLabel.Visible = false;
            passwordWarningLabel.Visible = false;
            passwordsMatchWarningLabel.Visible = false;
            passwordRequired8Characters.Visible = false;

            passwordInvalidUpperLetter.Visible = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Check if username field is empty
            string usernameTrimmed = Regex.Replace(usernameTextBox.Text, @"\s", "");


            if (String.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                shortUsernameWarningLabel.Visible = false;
                invalidUsernameWarningLabel.Visible = false;
                usernameWarningLabel.Visible = true;

            }
            else if (usernameTrimmed.Length == usernameTextBox.Text.Length)
            {
                usernameWarningLabel.Visible = false;
                shortUsernameWarningLabel.Visible = false;
                invalidUsernameWarningLabel.Visible = false;
            }
            else if (usernameTextBox.TextLength < 3)
            {
                usernameWarningLabel.Visible = false;
                invalidUsernameWarningLabel.Visible = false;
                shortUsernameWarningLabel.Visible = true;

            }
            else if (usernameTrimmed.Length != usernameTextBox.TextLength)
            {

                usernameWarningLabel.Visible = false;
                shortUsernameWarningLabel.Visible = false;
                invalidUsernameWarningLabel.Visible = true;
            }


            // Check if email field is empty


            if (String.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                invalidEmailAddressWarningLabel.Visible = false;
                emailWarningLabel.Visible = true;
            }
            else
            {
                try
                {
                    new System.Net.Mail.MailAddress(this.emailTextBox.Text);
                    invalidEmailAddressWarningLabel.Visible = false;
                    emailWarningLabel.Visible = false;
                }
                catch (FormatException)
                {
                    invalidEmailAddressWarningLabel.Visible = true;
                }

            }

            // Check if password field is empty

            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                invalidPasswordNoNumber.Visible = false;
                passwordRequired8Characters.Visible = false;
                passwordInvalidUpperLetter.Visible = false;
                passwordWarningLabel.Visible = true;
            }
            else
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinimum8Chars = new Regex(@".{8,}");
                bool isValidated;

                if (!(isValidated = hasMinimum8Chars.IsMatch(passwordTextBox.Text)))
                {
                    passwordWarningLabel.Visible = false;
                    passwordInvalidUpperLetter.Visible = false;
                    invalidPasswordNoNumber.Visible = false;
                    passwordRequired8Characters.Visible = !isValidated;

                }
                else if (!(isValidated = hasUpperChar.IsMatch(passwordTextBox.Text)))
                {
                    passwordWarningLabel.Visible = false;
                    passwordRequired8Characters.Visible = false;
                    invalidPasswordNoNumber.Visible = false;
                    passwordInvalidUpperLetter.Visible = !isValidated;

                }
                else if (!(isValidated = hasNumber.IsMatch(passwordTextBox.Text)))
                {
                    passwordWarningLabel.Visible = false;
                    passwordRequired8Characters.Visible = false;
                    passwordInvalidUpperLetter.Visible = false;
                    invalidPasswordNoNumber.Visible = !isValidated;

                }
                else
                {
                    passwordWarningLabel.Visible = false;
                    passwordRequired8Characters.Visible = false;
                    invalidPasswordNoNumber.Visible = false;
                    passwordInvalidUpperLetter.Visible = false;

                }

            }

            // Check if passwords match

            passwordsMatchWarningLabel.Visible = passwordTextBox.Text != passwordConfirmTextbox.Text;


            // Check if there are no warnings
            if (!(usernameWarningLabel.Visible || invalidUsernameWarningLabel.Visible || shortUsernameWarningLabel.Visible || emailWarningLabel.Visible || invalidEmailAddressWarningLabel.Visible || invalidPasswordNoNumber.Visible || passwordInvalidUpperLetter.Visible || passwordWarningLabel.Visible || passwordRequired8Characters.Visible || passwordsMatchWarningLabel.Visible))
            {
                // Sign up succesfull
                // Add a user to the system


                if (String.IsNullOrWhiteSpace(phoneTextBox.Text))
                {
                    FileManager.InsertUser(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, Role);
                }
                else
                {
                    FileManager.InsertUser(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, phoneTextBox.Text);
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
