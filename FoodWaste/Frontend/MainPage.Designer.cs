
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
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.gridClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReserveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UnReserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestaurantListButton = new System.Windows.Forms.Button();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SettingsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.gridClick.SuspendLayout();
            this.SettingsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.ContextMenuStrip = this.gridClick;
            this.MainDataGridView.Location = new System.Drawing.Point(13, 195);
            this.MainDataGridView.MultiSelect = false;
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(680, 308);
            this.MainDataGridView.TabIndex = 0;
            this.MainDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainDataGridView_MouseDown);
            // 
            // gridClick
            // 
            this.gridClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReserveStripMenu,
            this.UnReserveToolStripMenuItem});
            this.gridClick.Name = "gridClick";
            this.gridClick.Size = new System.Drawing.Size(130, 48);
            this.gridClick.Opening += new System.ComponentModel.CancelEventHandler(this.gridClick_Opening);
            // 
            // ReserveStripMenu
            // 
            this.ReserveStripMenu.Name = "ReserveStripMenu";
            this.ReserveStripMenu.Size = new System.Drawing.Size(129, 22);
            this.ReserveStripMenu.Text = "Reserve";
            this.ReserveStripMenu.Click += new System.EventHandler(this.RegisterStripMenuReserve_Click);
            // 
            // UnReserveToolStripMenuItem
            // 
            this.UnReserveToolStripMenuItem.Name = "UnReserveToolStripMenuItem";
            this.UnReserveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.UnReserveToolStripMenuItem.Text = "UnReserve";
            this.UnReserveToolStripMenuItem.Click += new System.EventHandler(this.UnReserveToolStripMenuItem_Click);
            // 
            // RestaurantListButton
            // 
            this.RestaurantListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.RestaurantListButton.Location = new System.Drawing.Point(649, 544);
            this.RestaurantListButton.Name = "RestaurantListButton";
            this.RestaurantListButton.Size = new System.Drawing.Size(167, 38);
            this.RestaurantListButton.TabIndex = 1;
            this.RestaurantListButton.Text = "Restaurant list";
            this.RestaurantListButton.UseVisualStyleBackColor = true;
            this.RestaurantListButton.Click += new System.EventHandler(this.RestaurantListButton_Click);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(13, 116);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(175, 21);
            this.FilterComboBox.TabIndex = 2;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FilterLabel.Location = new System.Drawing.Point(12, 87);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(60, 26);
            this.FilterLabel.TabIndex = 3;
            this.FilterLabel.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // StartingDateTimePicker
            // 
            this.StartingDateTimePicker.Location = new System.Drawing.Point(12, 169);
            this.StartingDateTimePicker.Name = "StartingDateTimePicker";
            this.StartingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartingDateTimePicker.TabIndex = 5;
            this.StartingDateTimePicker.Visible = false;
            // 
            // EndingDateTimePicker
            // 
            this.EndingDateTimePicker.Location = new System.Drawing.Point(218, 169);
            this.EndingDateTimePicker.Name = "EndingDateTimePicker";
            this.EndingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndingDateTimePicker.TabIndex = 6;
            this.EndingDateTimePicker.Visible = false;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(194, 116);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 7;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Visible = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButtonClick);
            // 
            // SettingsMenuStrip
            // 
            this.SettingsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.SettingsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SettingsMenuStrip.Name = "SettingsMenuStrip";
            this.SettingsMenuStrip.Size = new System.Drawing.Size(828, 24);
            this.SettingsMenuStrip.TabIndex = 8;
            this.SettingsMenuStrip.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountSettingsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // AccountSettingsToolStripMenuItem
            // 
            this.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem";
            this.AccountSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AccountSettingsToolStripMenuItem.Text = "Account settings";
            this.AccountSettingsToolStripMenuItem.Click += new System.EventHandler(this.AccountSettingsToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 594);
            this.Controls.Add(this.SettingsMenuStrip);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.EndingDateTimePicker);
            this.Controls.Add(this.StartingDateTimePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.RestaurantListButton);
            this.Controls.Add(this.MainDataGridView);
            this.MainMenuStrip = this.SettingsMenuStrip;
            this.MinimumSize = new System.Drawing.Size(721, 521);
            this.Name = "MainPage";
            this.Text = "Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.gridClick.ResumeLayout(false);
            this.SettingsMenuStrip.ResumeLayout(false);
            this.SettingsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Button RestaurantListButton;
        private System.Windows.Forms.ToolStripMenuItem ReserveStripMenu;
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
        private System.Windows.Forms.ToolStripMenuItem UnReserveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip SettingsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountSettingsToolStripMenuItem;
    }
}