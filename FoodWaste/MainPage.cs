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
        private FileManager Reader;
        public MainPage()
        {
            InitializeComponent();
            Reader = new FileManager();
            ProductList = Reader.GetProductsFromFile();
            dataGridView1.DataSource = ProductList;
            InitFilterValues();
        }
        private void InitFilterValues() {
            comboBox1.Items.Add("Default view");
            comboBox1.Items.Add("Expiration date");
            comboBox1.Items.Add("Product");

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
            if (MessageBox.Show("Do you want to reserve " + dataGridView1.Rows[index].Cells[0].Value + "?", "Reservation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows[index].Cells[2].Value = Product.ProductState.reserved;
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
            dataGridView.ClearSelection();
            dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
            this.dataGridView1.CurrentCell = dataGridView.Rows[hitTestInfo.RowIndex].Cells[0];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex == 0) {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                textBox1.Visible = false;
            }
            if (selectedIndex == 1) {
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                textBox1.Visible = false;
            }
            if (selectedIndex == 2) {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                textBox1.Visible = true;
            }

            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex == 0)
            {
                dataGridView1.DataSource = ProductList;
            }
            if (selectedIndex == 1)
            {

                dataGridView1.DataSource = ProductList.Where(x => (x.ExpiryDate >= dateTimePicker1.Value.Date && x.ExpiryDate <= dateTimePicker2.Value.Date)).ToList();
            }
            if (selectedIndex == 2)
            {
                dataGridView1.DataSource = ProductList.Where(x => x.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            }
        }
    }
}
