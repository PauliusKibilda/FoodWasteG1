﻿
namespace FoodWaste
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registerStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestaurantListButton = new System.Windows.Forms.Button();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.gridClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.MainDataGridView.ContextMenuStrip = this.gridClick;
            this.MainDataGridView.Location = new System.Drawing.Point(52, 118);
            this.MainDataGridView.MultiSelect = false;
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(680, 308);
            this.MainDataGridView.TabIndex = 0;
            this.MainDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainDataGridView_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ExpiryDate";
            dataGridViewCellStyle1.Format = "yyyy-MM-dd";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Expiration date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "State";
            this.Column3.HeaderText = "State";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // gridClick
            // 
            this.gridClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStripMenu});
            this.gridClick.Name = "gridClick";
            this.gridClick.Size = new System.Drawing.Size(115, 26);
            // 
            // registerStripMenu
            // 
            this.registerStripMenu.Name = "registerStripMenu";
            this.registerStripMenu.Size = new System.Drawing.Size(114, 22);
            this.registerStripMenu.Text = "Reserve";
            this.registerStripMenu.Click += new System.EventHandler(this.RegisterStripMenuReserve_Click);
            // 
            // RestaurantListButton
            // 
            this.RestaurantListButton.Location = new System.Drawing.Point(679, 513);
            this.RestaurantListButton.Name = "RestaurantListButton";
            this.RestaurantListButton.Size = new System.Drawing.Size(107, 23);
            this.RestaurantListButton.TabIndex = 1;
            this.RestaurantListButton.Text = "Restaurant list";
            this.RestaurantListButton.UseVisualStyleBackColor = true;
            this.RestaurantListButton.Click += new System.EventHandler(this.RestaurantListButton_Click);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(52, 37);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(175, 21);
            this.FilterComboBox.TabIndex = 2;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FilterLabel.Location = new System.Drawing.Point(48, 14);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(44, 20);
            this.FilterLabel.TabIndex = 3;
            this.FilterLabel.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // StartingDateTimePicker
            // 
            this.StartingDateTimePicker.Location = new System.Drawing.Point(52, 65);
            this.StartingDateTimePicker.Name = "StartingDateTimePicker";
            this.StartingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartingDateTimePicker.TabIndex = 5;
            this.StartingDateTimePicker.Visible = false;
            // 
            // EndingDateTimePicker
            // 
            this.EndingDateTimePicker.Location = new System.Drawing.Point(271, 65);
            this.EndingDateTimePicker.Name = "EndingDateTimePicker";
            this.EndingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndingDateTimePicker.TabIndex = 6;
            this.EndingDateTimePicker.Visible = false;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(233, 37);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 7;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Visible = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButtonClick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 594);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.EndingDateTimePicker);
            this.Controls.Add(this.StartingDateTimePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.RestaurantListButton);
            this.Controls.Add(this.MainDataGridView);
            this.Name = "MainPage";
            this.Text = "Main page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.gridClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Button RestaurantListButton;
        private System.Windows.Forms.ToolStripMenuItem registerStripMenu;
        private System.Windows.Forms.ContextMenuStrip gridClick;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker StartingDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndingDateTimePicker;
        private System.Windows.Forms.Button FilterButton;
    }
}