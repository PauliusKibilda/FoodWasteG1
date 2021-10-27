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
using FoodWaste.Frontend;

namespace FoodWaste
{
    public partial class RegisterPage : Form
    {
        private string Role;
        private User User;
        public RegisterPage(string role)
        {
            Role = role;
            InitializeComponent();
            this.CenterToScreen();
            UsernameWarningLabel.Visible = false;
            EmailWarningLabel.Visible = false;
            PasswordWarningLabel.Visible = false;
            PasswordsMatchWarningLabel.Visible = false;
            if (Role.Equals("Restaurant")) 
            {
                SignUpButton.Text = "Next";
            }
        }
        public RegisterPage(User user)
        {
            User = user;
            Role = user.Role;
            InitializeComponent();
            this.CenterToScreen();
            UsernameWarningLabel.Visible = false;
            EmailWarningLabel.Visible = false;
            PasswordWarningLabel.Visible = false;
            PasswordsMatchWarningLabel.Visible = false;
            SignUpButton.Text = "Next";
            UsernameTextBox.Text = User.UserName;
            EmailTextBox.Text = User.Email;
            PhoneTextBox.Text = User.Mobile;
            PasswordTextBox.Text = PasswordConfirmTextbox.Text = User.Password;
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

            if (!PhoneTextBox.Text.IsValidPhoneNumber())
            {
                PhoneNumberWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                PhoneNumberWarningLabel.Visible = true;
            }
            else PhoneNumberWarningLabel.Visible = false;



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
                if (Role.Equals("Restaurant"))
                {
                    if (User == null)
                    {
                        User = GetUser(PasswordTextBox.Text);
                    }
                    OpenForm(new RestaurantRegistration(User));
                }
                else
                {
                    string passwordHash = Hash.GetHashString(PasswordTextBox.Text);
                    User = GetUser(passwordHash);
                    if (String.IsNullOrWhiteSpace(PhoneTextBox.Text))
                    {
                        FileManager.InsertUser(User);
                    }
                    else
                    {
                        FileManager.InsertUser(User);
                    }
                    MessageBox.Show("User " + UsernameTextBox.Text + " registered succesfully.");
                    BackToLoginPage();
                }
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
            OpenForm(new LoginPage());
        }
        private User GetUser(string password) 
        {
            if (String.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                return new User(UsernameTextBox.Text, EmailTextBox.Text, password, Role);
            }
            else
            {
                return new User(UsernameTextBox.Text, EmailTextBox.Text, password, Role, PhoneTextBox.Text);
            }
        }
        private void OpenForm(Form form) 
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
