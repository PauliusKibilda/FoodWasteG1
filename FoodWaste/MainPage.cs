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
        ProductList Products = new ProductList();
        private User User;
        ProductList VisibleProductList = new ProductList();
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
            Products = FileManager.GetProductsFromFile();

            VisibleProductList = Products;
            MainDataGridView.DataSource = Products.List;
            sortKey.columnIndex = 0;
            sortKey.order = Order.asc;
            VisibleProductList.Sort(new ProductComparer(sortKey));
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
                Products[index].ReservedUsername = User.UserName;
                MainDataGridView.Update();
                MainDataGridView.Refresh();
                FileManager.InsertProducts(Products.List);
            }
        }

        private void MainDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
            
            if (hitTestInfo.Type == DataGridViewHitTestType.ColumnHeader)
            {
                if (sortKey.columnIndex == hitTestInfo.ColumnIndex)
                {
                    sortKey.order = (sortKey.order == Order.desc) ? Order.asc : Order.desc;
                }
                sortKey.columnIndex = hitTestInfo.ColumnIndex;

                VisibleProductList.Sort(new ProductComparer(sortKey));
                
                MainDataGridView.Refresh();
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
                MainDataGridView.DataSource = Products.List;
            }
            if (selectedIndex == 1)
            {
                VisibleProductList = Products.Where(x => (x.ExpiryDate >= StartingDateTimePicker.Value.Date && x.ExpiryDate <= EndingDateTimePicker.Value.Date)).ToList();
                MainDataGridView.DataSource = VisibleProductList.List;
            }
            if (selectedIndex == 2)
            {
                VisibleProductList = Products.Where(x => x.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                MainDataGridView.DataSource = VisibleProductList.List;
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
                if (Products[index] == null)
                {
                    e.Cancel = true;
                }
                else
                {
                    ReserveStripMenu.Enabled = Products[index].State.Equals(Product.ProductState.Listed);
                    UnReserveToolStripMenuItem.Enabled = (Products[index].State.Equals(Product.ProductState.Reserved) && Products[index].ReservedUsername.Equals(User.UserName));
                }
            }
        }

        private void UnReserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetSelectedRowIndex();
            if (Products[index] == null)
            {
                return;
            }
            if (MessageBox.Show("Do you want to unreserve " + MainDataGridView.Rows[index].Cells[0].Value + "?", "Reservation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainDataGridView.Rows[index].Cells[2].Value = Product.ProductState.Listed;
                Products[index].ReservedUsername = "";
                MainDataGridView.Update();
                MainDataGridView.Refresh();
                FileManager.InsertProducts(Products.List);
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
