
namespace FoodWaste
{
    partial class RegisterOptions
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
            this.RestaurantButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.RegisterText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestaurantButton
            // 
            this.RestaurantButton.Location = new System.Drawing.Point(61, 136);
            this.RestaurantButton.Name = "RestaurantButton";
            this.RestaurantButton.Size = new System.Drawing.Size(75, 23);
            this.RestaurantButton.TabIndex = 0;
            this.RestaurantButton.Text = "Restaurant";
            this.RestaurantButton.UseVisualStyleBackColor = true;
            this.RestaurantButton.Click += new System.EventHandler(this.RestaurantButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(220, 136);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(75, 23);
            this.UserButton.TabIndex = 1;
            this.UserButton.Text = "User";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // RegisterText
            // 
            this.RegisterText.AutoSize = true;
            this.RegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterText.Location = new System.Drawing.Point(12, 40);
            this.RegisterText.Name = "RegisterText";
            this.RegisterText.Size = new System.Drawing.Size(333, 25);
            this.RegisterText.TabIndex = 2;
            this.RegisterText.Text = "For what pupose are you registering?";
            // 
            // RegisterOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 186);
            this.Controls.Add(this.RegisterText);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.RestaurantButton);
            this.Name = "RegisterOptions";
            this.Text = "RegisterOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestaurantButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Label RegisterText;
    }
}