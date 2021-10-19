
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
            ((System.ComponentModel.ISupportInitialize)(this.restDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restDataGridView
            // 
            this.restDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restDataGridView.Location = new System.Drawing.Point(12, 12);
            this.restDataGridView.Name = "restDataGridView";
            this.restDataGridView.Size = new System.Drawing.Size(580, 326);
            this.restDataGridView.TabIndex = 0;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(194, 344);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(234, 27);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Add new product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // RestaurantMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 384);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.restDataGridView);
            this.Name = "RestaurantMainPage";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestaurantMainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.restDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView restDataGridView;
        private System.Windows.Forms.Button AddProductButton;
    }
}