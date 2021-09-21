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
    public partial class MainPage : Form
    {
        private List<Product> productList = new List<Product>();
        public MainPage()
        {
            InitializeComponent();
            initDataGridViewColumns();
        }

        public void initDataGridViewColumns()
        {
            DataTable dt = GetTable();
            FillTable(dt);
            dataGridView1.DataSource = dt;
        }

        private DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Produktas", typeof(string));
            //dt.Columns.Add("Restoranas", typeof(string));
            dt.Columns.Add("Galiojimo pabaiga", typeof(string));
            dt.Columns.Add("Būsena", typeof(string));
           // dt.Columns.Add("Kaina", typeof(string));
            return dt;
        }
        private void FillTable(DataTable dt)
        {
            foreach (Product product in productList) 
            {
                dt.Rows.Add(product.ProductName, product.ExpiryDate, product.State);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantPage restaurantPage = new RestaurantPage();
            restaurantPage.ShowDialog();
        }

    }
}
