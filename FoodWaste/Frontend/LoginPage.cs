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

        public User CheckLoginCredentials(string username, string password)
        {
            UserList = FileManager.GetUsersFromFile();
            return (from User user in UserList
                    where username == user.UserName && Hash.GetHashString(password) == user.Password
                    select user).SingleOrDefault();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = CheckLoginCredentials(usernameTextBox.Text, passwordTextBox.Text);
            if (user != null)
            {
                if (user.Role == "User")
                {
                    OpenPage(new MainPage(user));
                }

                if (user.Role == "Restaurant")
                {
                    OpenPage(new RestaurantMainPage(user));
                }
            }
            else
            {
                IncorectCredentialsLabel.Visible = true;
            }
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckbox.Checked;
        }

        private void ContinueAsGuestButton_Click(object sender, EventArgs e)
        {
            OpenPage(new MainPage(null));
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterOptions registerPage = new RegisterOptions();
            registerPage.ShowDialog();
            this.Close();
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenPage(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}

