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
        private User User;
        private List<Product> VisibleProductList = new List<Product>();
        SortKey sortKey = new SortKey();
        public MainPage(User user)
        {
            InitializeComponent();
            this.CenterToScreen();
            User = user;
            if (User == null)
            {
                SettingsMenuStrip.Visible = false;
            }
            ProductList = FileManager.GetProductsFromFile();
            VisibleProductList = ProductList;
            sortKey.collumnIndex = -1;
            sortKey.order = Order.asc;
            MainDataGridView.DataSource = ProductList;
            InitFilterValues();
        }
        private void InitFilterValues() 
        {
            FilterComboBox.Items.Add("Default view");
            FilterComboBox.Items.Add("Expiration date");
            FilterComboBox.Items.Add("Product");
        }
        private void RestaurantListButton_Click(object sender, EventArgs e)
        {
            RestaurantPage restaurantPage = new RestaurantPage();
            restaurantPage.ShowDialog();
        }
        private void RegisterStripMenuReserve_Click(object sender, EventArgs e) 
        {
            int index = GetSelectedRowIndex();
            if (index == -1) 
            {
                return;
            }
            if (MessageBox.Show("Do you want to reserve " + MainDataGridView.Rows[index].Cells[0].Value + "?", "Reservation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainDataGridView.Rows[index].Cells[2].Value = Product.ProductState.Reserved;
                ProductList[index].ReservedUsername = User.UserName;
                MainDataGridView.Update();
                MainDataGridView.Refresh();
                FileManager.InsertProducts(new List<Product>(ProductList));
            }
        }

        private void MainDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
            
            if (hitTestInfo.Type == DataGridViewHitTestType.ColumnHeader)
            {
                List<Product> sortedProductList; // IEnumerable

                switch (hitTestInfo.ColumnIndex)
                {
                    case 0:
                        sortedProductList = VisibleProductList.OrderBy(product => product.Name).ToList();
                        break;
                    case 1:
                        sortedProductList = VisibleProductList.OrderBy(product => product.ExpiryDate).ToList();
                        break;
                    case 2:
                        sortedProductList = VisibleProductList.OrderBy(product => product.State.ToString()).ToList();
                        break;
                    default:
                        sortedProductList = VisibleProductList.OrderBy(product => product.Name).ToList();
                        break;
                }
                if (sortKey.collumnIndex == hitTestInfo.ColumnIndex)
                {
                    if (sortKey.order == Order.desc)
                        sortKey.order = Order.asc;
                    else
                        sortKey.order = Order.desc;
                }
                if (sortKey.order == Order.desc)
                {
                    sortedProductList.Reverse();
                }
                sortKey.collumnIndex = hitTestInfo.ColumnIndex;
                MainDataGridView.DataSource = sortedProductList;
            }
            else if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
                this.MainDataGridView.CurrentCell = dataGridView.Rows[hitTestInfo.RowIndex].Cells[0];
            }

        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FilterComboBox.SelectedIndex;
            if (selectedIndex == 0)
            {
                StartingDateTimePicker.Visible = false;
                EndingDateTimePicker.Visible = false;
                textBox1.Visible = false;
            }
            if (selectedIndex == 1)
            {
                StartingDateTimePicker.Visible = true;
                EndingDateTimePicker.Visible = true;
                textBox1.Visible = false;
            }
            if (selectedIndex == 2)
            {
                StartingDateTimePicker.Visible = false;
                EndingDateTimePicker.Visible = false;
                textBox1.Visible = true;
            }

            FilterButton.Visible = true;
        }

        private void FilterButtonClick(object sender, EventArgs e)
        {
            int selectedIndex = FilterComboBox.SelectedIndex;

            if (selectedIndex == 0)
            {
                MainDataGridView.DataSource = ProductList;
            }
            if (selectedIndex == 1)
            {
                VisibleProductList = ProductList.Where(x => (x.ExpiryDate >= StartingDateTimePicker.Value.Date && x.ExpiryDate <= EndingDateTimePicker.Value.Date)).ToList();
                MainDataGridView.DataSource = VisibleProductList;
            }
            if (selectedIndex == 2)
            {
                VisibleProductList = ProductList.Where(x => x.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                MainDataGridView.DataSource = VisibleProductList;
            }
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void gridClick_Opening(object sender, CancelEventArgs e)
        {
            if (User == null)
            {
                MessageBox.Show("You must register to reserve products!");
                e.Cancel = true;
            }
            else
            {
                int index = GetSelectedRowIndex();
                if (index == -1)
                {
                    e.Cancel = true;
                }
                if (User.UserName != ProductList[index].ReservedUsername)
                {
                    UnReserveToolStripMenuItem.Enabled = false;
                    ReserveStripMenu.Enabled = true;
                }
                else
                {
                    UnReserveToolStripMenuItem.Enabled = true;
                    ReserveStripMenu.Enabled = false;
                }
            }
        }

        private void UnReserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetSelectedRowIndex();
            if (index == -1)
            {
                return;
            }
            if (MessageBox.Show("Do you want to unreserve " + MainDataGridView.Rows[index].Cells[0].Value + "?", "Reservation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainDataGridView.Rows[index].Cells[2].Value = Product.ProductState.Listed;
                ProductList[index].ReservedUsername = "";
                MainDataGridView.Update();
                MainDataGridView.Refresh();
                FileManager.InsertProducts(new List<Product>(ProductList));
            }
        }
        private int GetSelectedRowIndex() 
        {
            if (this.MainDataGridView.SelectedRows.Count == 0)
            {
                return -1;
            }
            int index = this.MainDataGridView.SelectedRows[0].Index;
            return index;
        }

        private void AccountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings(User);
            userSettings.ShowDialog();
        }
    }
}
