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
    public partial class UserSettings : Form
    {
        private User User;
        public UserSettings(User user)
        {
            InitializeComponent();
            User = user;
            EmailTextBox.Text = user.Email;
            PhoneTextBox.Text = user.Mobile;
        }

        private void ChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangePassword.Checked)
            {
                PasswordLabel.Visible = true;
                PasswordTextBox.Visible = true;
                ConfirmPasswordLabel.Visible = true;
                ConfirmPasswordTextbox.Visible = true;
            }
            else
            {
                PasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;
                ConfirmPasswordLabel.Visible = false;
                ConfirmPasswordTextbox.Visible = false;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!RegisterPageValidation.ValidateEmailAddress(EmailTextBox.Text))
            {
                EmailWarningLabel.Text = RegisterPageValidation.getErrorMessage();
                EmailWarningLabel.Visible = true;
            }
            else
                EmailWarningLabel.Visible = false;
            
            
            if (ChangePassword.Checked)
            {
                if (!RegisterPageValidation.ValidatePassword(PasswordTextBox.Text))
                {
                    PasswordWarningLabel.Text = RegisterPageValidation.getErrorMessage();
                    PasswordWarningLabel.Visible = true;
                }
                else 
                    PasswordWarningLabel.Visible = false;

                if (!RegisterPageValidation.IsPasswordSame(PasswordTextBox.Text, ConfirmPasswordTextbox.Text))
                {
                    PasswordsMatchWarningLabel.Text = RegisterPageValidation.getErrorMessage();
                    PasswordsMatchWarningLabel.Visible = true;
                }
                else
                    PasswordsMatchWarningLabel.Visible = false;
            }
            if (!(EmailWarningLabel.Visible || PasswordWarningLabel.Visible || PasswordsMatchWarningLabel.Visible))
            {
                User.Email = EmailTextBox.Text;
                User.Mobile = PhoneTextBox.Text;
                User.Password = Hash.GetHashString(PasswordTextBox.Text);
                FileManager.InsertChangedUser(User);
                MessageBox.Show("Successfully changed account information!");
            }
        }
    }
}