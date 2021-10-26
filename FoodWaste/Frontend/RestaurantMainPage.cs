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
            RestDataGridView.DataSource = ProductList.Where(x => x.RestaurantName == user.UserName).ToList();
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
            RestDataGridView.DataSource = ProductList.Where(x => x.RestaurantName == User.UserName).ToList();
        }
        private void RestaurantMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void RestDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);

            dataGridView.ClearSelection();
            dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
            this.RestDataGridView.CurrentCell = dataGridView.Rows[hitTestInfo.RowIndex].Cells[0];

        }

        private int GetSelectedRowIndex()
        {
            if (this.RestDataGridView.SelectedRows.Count == 0)
            {
                return -1;
            }
            int index = this.RestDataGridView.SelectedRows[0].Index;
            return index;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetSelectedRowIndex();
            FileManager.DeleteProduct(ProductList[index]);
            RestDataGridView.Refresh();
        }
    }
}
