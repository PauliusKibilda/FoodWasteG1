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
    public partial class RegisterOptions : Form
    {
        public RegisterOptions()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void RestaurantButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            RegisterPage registerPage = new RegisterPage("Restaurant");
            registerPage.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            RegisterPage registerPage = new RegisterPage("User");
            registerPage.ShowDialog();
        }

        private void RegisterOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
        }
    }
}
