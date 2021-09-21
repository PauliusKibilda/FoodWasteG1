
namespace FoodWaste
{
    partial class Form1
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameTextBox.Location = new System.Drawing.Point(293, 163);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(214, 32);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordTextBox.Location = new System.Drawing.Point(293, 221);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(214, 32);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameLabel.Location = new System.Drawing.Point(293, 137);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(119, 26);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordLabel.Location = new System.Drawing.Point(293, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(114, 26);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.loginButton.Location = new System.Drawing.Point(403, 259);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(104, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckbox.AutoSize = true;
            this.showPasswordCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.showPasswordCheckbox.Location = new System.Drawing.Point(293, 260);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckbox.TabIndex = 5;
            this.showPasswordCheckbox.Text = "Show Password";
            this.showPasswordCheckbox.UseVisualStyleBackColor = true;
            this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.showPasswordCheckbox_CheckedChanged);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.backButton.Location = new System.Drawing.Point(12, 398);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 40);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.signupButton.Location = new System.Drawing.Point(684, 398);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(104, 40);
            this.signupButton.TabIndex = 7;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox showPasswordCheckbox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button signupButton;
    }
}

