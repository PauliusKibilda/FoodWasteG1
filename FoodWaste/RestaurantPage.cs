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
    public partial class RestaurantPage : Form
    {
        private List<Restaurant> RestaurantList = new List<Restaurant>();
        private FileManager Reader;
        public RestaurantPage()
        {
            InitializeComponent();
            Reader = new FileManager();
            RestaurantList = Reader.GetRestaurantsFromFile();
            InitDataGridViewColumns();
        }
        public void InitDataGridViewColumns()
        {
            DataTable dt = GetTable();
            FillTable(dt);
            dataGridView1.DataSource = dt;
        }

        private DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Restoranas", typeof(string));
            dt.Columns.Add("Adresas", typeof(string));
            dt.Columns.Add("Telefonas", typeof(string));
            // dt.Columns.Add("Darbo laikas", typeof(string));
            return dt;
        }
        private void FillTable(DataTable dt)
        {
            foreach (Restaurant restaurant in RestaurantList)
            {
                dt.Rows.Add(restaurant.RestaurantName, restaurant.Adress, restaurant.PhoneNumber);
            }
        }
    }
}
