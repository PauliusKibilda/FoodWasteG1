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
        private List<Product> ProductList = new List<Product>();
        private Reader Reader;
        public MainPage()
        {
            InitializeComponent();
            Reader = new Reader();
            ProductList = Reader.GetProductsFromFile();
            dataGridView1.DataSource = ProductList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantPage restaurantPage = new RestaurantPage();
            restaurantPage.ShowDialog();
        }
        private void menuItem1_Click(object sender, EventArgs e) 
        {
            if (this.dataGridView1.SelectedRows.Count == 0) 
            {
                return;
            }
            int index = this.dataGridView1.SelectedRows[0].Index;
            if (index == -1) 
            {
                return;
            }
            ProductList[index].State = Product.ProductState.reserved;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
            dataGridView.ClearSelection();
            dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
            this.dataGridView1.CurrentCell = dataGridView.Rows[hitTestInfo.RowIndex].Cells[0];

        }
    }
}
