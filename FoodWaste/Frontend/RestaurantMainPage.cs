using FoodWaste.Frontend;
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
    public partial class RestaurantMainPage : Form
    {
        private ObjectList<Product> ProductList = new ObjectList<Product>();
        private User User;

        public RestaurantMainPage(User user)
        {
            InitializeComponent();
            User = user;
            this.CenterToScreen();
            ProductList = FileManager.GetProductsFromFile();
            restDataGridView.DataSource = ProductList.Where(x => x.RestaurantName == user.UserName).ToList();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductAddingPage productAddingPage = new ProductAddingPage(User);
            productAddingPage.FormClosing += ProductAddingPage_FormClosing;
            productAddingPage.ShowDialog();
        }

        private void ProductAddingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductList = FileManager.GetProductsFromFile();
            restDataGridView.DataSource = ProductList.Where(x => x.RestaurantName == User.UserName).ToList();
        }

        private void RestaurantMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void RestaurantSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = GetRestaurantByUserName(User.UserName);
            if (restaurant != null)
            {
                RestaurantRegistration restaurantRegistration = new RestaurantRegistration(restaurant);
                restaurantRegistration.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Could not retrieve restaurant info");
            }
        }

        private void AccountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings(User);
            userSettings.ShowDialog();
        }
        private Restaurant GetRestaurantByUserName(string userName)
        {
            foreach (Restaurant restaurant in FileManager.GetRestaurantsFromFile())
            {
                if (restaurant.UserName.Equals(userName))
                {
                    return restaurant;
                }
            }
            return null;
        }
    }
}
