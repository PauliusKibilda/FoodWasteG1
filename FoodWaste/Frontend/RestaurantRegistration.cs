using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodWaste.Frontend
{
    public partial class RestaurantRegistration : Form
    {
        private User User;
        private Restaurant Restaurant;
        public RestaurantRegistration(User user)
        {
            InitializeComponent();
            this.CenterToScreen();
            User = user;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestaurantRegistration_FormClosed);
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
        }
        public RestaurantRegistration(Restaurant restaurant) 
        {
            InitializeComponent();
            this.CenterToScreen();
            Restaurant = restaurant;
            RegisterButton.Text = "Update";
            this.BackButton.Click += new System.EventHandler(this.BackButtonSettings_Click);
            this.RegisterButton.Click += new System.EventHandler(this.UpdateButton_Click);
            RestaurantNameTextBox.Text = Restaurant.RestaurantName;
            AdressTextBox.Text = Restaurant.Adress;
            PhoneNumberTextBox.Text = Restaurant.PhoneNumber;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Todo: regex when it is implemented
            string passwordHash = Hash.GetHashString(User.Password);
            User.Password = passwordHash;
            FileManager.InsertRestaurant(RestaurantNameTextBox.Text, PhoneNumberTextBox.Text, AdressTextBox.Text, User.UserName);
            FileManager.InsertUser(User);
            MessageBox.Show("User " + User.UserName + " registered succesfully.");
            OpenForm(new LoginPage());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OpenForm(new RegisterPage(User));
        }
        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void RestaurantRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void BackButtonSettings_Click(object sender, EventArgs e) 
        {
            this.Hide();
            this.Close();

        }
        private void UpdateButton_Click(object sender, EventArgs e) 
        {
            //Todo when validation is implemented
            Restaurant.RestaurantName = RestaurantNameTextBox.Text;
            Restaurant.Adress = AdressTextBox.Text;
            Restaurant.PhoneNumber = PhoneNumberTextBox.Text;
            FileManager.InserChangedRestaurant(Restaurant);
            MessageBox.Show("Updated succesfully.");
        }
    }
}
