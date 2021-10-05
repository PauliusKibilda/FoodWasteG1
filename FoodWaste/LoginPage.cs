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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private List<User> UserList = new List<User>();

        // Check if username and password that are filled in are 
        
        public bool CheckLoginCredentials(string username, string password)
        {
            UserList = FileManager.GetUsersFromFile();
            foreach (User user in UserList)
            {
                if (username == user.UserName && password == user.Password)
                    return true;
            }
            return false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CheckLoginCredentials(usernameTextBox.Text, passwordTextBox.Text))
            {
                OpenMainPage();
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

        private void ContinueAsGuestButton_Click(object sender, EventArgs e)
        {
            OpenMainPage();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterOptions registerPage = new RegisterOptions();
            registerPage.ShowDialog();
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenMainPage()
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }
    }
}
