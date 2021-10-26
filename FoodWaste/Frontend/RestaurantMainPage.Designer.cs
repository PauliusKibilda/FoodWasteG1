
namespace FoodWaste
{
    partial class RestaurantMainPage
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
            this.restDataGridView = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SettingsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestaurantSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.restDataGridView)).BeginInit();
            this.SettingsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // restDataGridView
            // 
            this.restDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restDataGridView.Location = new System.Drawing.Point(12, 66);
            this.restDataGridView.Name = "restDataGridView";
            this.restDataGridView.Size = new System.Drawing.Size(580, 326);
            this.restDataGridView.TabIndex = 0;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(186, 398);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(234, 27);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Add new product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // SettingsMenuStrip
            // 
            this.SettingsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.SettingsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SettingsMenuStrip.Name = "SettingsMenuStrip";
            this.SettingsMenuStrip.Size = new System.Drawing.Size(617, 24);
            this.SettingsMenuStrip.TabIndex = 9;
            this.SettingsMenuStrip.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountSettingsToolStripMenuItem,
            this.RestaurantSettingsToolStripMenuItem});
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
            // RestaurantSettingsToolStripMenuItem
            // 
            this.RestaurantSettingsToolStripMenuItem.Name = "RestaurantSettingsToolStripMenuItem";
            this.RestaurantSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RestaurantSettingsToolStripMenuItem.Text = "Restaurant settings";
            this.RestaurantSettingsToolStripMenuItem.Click += new System.EventHandler(this.RestaurantSettingsToolStripMenuItem_Click);
            // 
            // RestaurantMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 454);
            this.Controls.Add(this.SettingsMenuStrip);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.restDataGridView);
            this.Name = "RestaurantMainPage";
            this.Text = "Restaurant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestaurantMainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.restDataGridView)).EndInit();
            this.SettingsMenuStrip.ResumeLayout(false);
            this.SettingsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView restDataGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.MenuStrip SettingsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestaurantSettingsToolStripMenuItem;
    }
}