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
    public partial class ProductAddingPage : Form
    {
        private string productName;
        private DateTime expirationDate;
        private User User;
        public ProductAddingPage(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productName = productNameTextBox.Text;
            expirationDate = productExpirationDate.Value;
            FileManager.AddProduct(productName, expirationDate, Product.ProductState.Listed, User.UserName);
            this.Close();
        }
    }
}
