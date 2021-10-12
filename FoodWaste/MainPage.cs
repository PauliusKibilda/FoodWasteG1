﻿using System;
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
        private List<Product> VisibleProductList = new List<Product>();
        SortKey sortKey = new SortKey();
        public MainPage()
        {
            InitializeComponent();
            this.CenterToScreen();
            ProductList = FileManager.GetProductsFromFile();
            VisibleProductList = ProductList;
            sortKey.type = -1;
            sortKey.order = OrderBy.asc;
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
            if (this.MainDataGridView.SelectedRows.Count == 0) 
            {
                return;
            }
            int index = this.MainDataGridView.SelectedRows[0].Index;
            if (index == -1) 
            {
                return;
            }
            if (MessageBox.Show("Do you want to reserve " + MainDataGridView.Rows[index].Cells[0].Value + "?", "Reservation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainDataGridView.Rows[index].Cells[2].Value = Product.ProductState.Reserved;
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
                List<Product> sortedProductList;

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
                if (sortKey.type == hitTestInfo.ColumnIndex)
                {
                    if (sortKey.order == OrderBy.desc)
                        sortKey.order = OrderBy.asc;
                    else
                        sortKey.order = OrderBy.desc;
                }
                if (sortKey.order == OrderBy.desc)
                {
                    sortedProductList.Reverse();
                }
                sortKey.type = hitTestInfo.ColumnIndex;
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
    }
}
