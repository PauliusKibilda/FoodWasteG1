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
            this.CenterToScreen();
            User = user;
            EmailTextBox.Text = user.Email;
            PhoneTextBox.Text = user.Mobile;
        }

        private void ChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordLabel.Visible = ChangePassword.Checked;
            PasswordTextBox.Visible = ChangePassword.Checked;
            ConfirmPasswordLabel.Visible = ChangePassword.Checked;
            ConfirmPasswordTextbox.Visible = ChangePassword.Checked;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!EmailTextBox.Text.IsValidEmailAddress())
            {
                EmailWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                EmailWarningLabel.Visible = true;
            }
            else
                EmailWarningLabel.Visible = false;
            
            
            if (ChangePassword.Checked)
            {
                if (!PasswordTextBox.Text.IsValidPassword())
                {
                    PasswordWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
                    PasswordWarningLabel.Visible = true;
                }
                else 
                    PasswordWarningLabel.Visible = false;

                if (!RegisterPageValidation.IsPasswordSame(PasswordTextBox.Text, ConfirmPasswordTextbox.Text))
                {
                    PasswordsMatchWarningLabel.Text = RegisterPageValidation.GetErrorMessage();
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}