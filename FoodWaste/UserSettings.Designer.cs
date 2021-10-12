namespace FoodWaste
{
    partial class UserSettings
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
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ChangePassword = new System.Windows.Forms.CheckBox();
            this.PasswordWarningLabel = new System.Windows.Forms.Label();
            this.EmailWarningLabel = new System.Windows.Forms.Label();
            this.PasswordsMatchWarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(144, 118);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(251, 26);
            this.PhoneNumberLabel.TabIndex = 27;
            this.PhoneNumberLabel.Text = "Phone number (optional)";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PhoneTextBox.Location = new System.Drawing.Point(149, 147);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(214, 32);
            this.PhoneTextBox.TabIndex = 26;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(144, 283);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(191, 26);
            this.ConfirmPasswordLabel.TabIndex = 25;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            this.ConfirmPasswordLabel.Visible = false;
            // 
            // ConfirmPasswordTextbox
            // 
            this.ConfirmPasswordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ConfirmPasswordTextbox.Location = new System.Drawing.Point(149, 312);
            this.ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            this.ConfirmPasswordTextbox.Size = new System.Drawing.Size(214, 32);
            this.ConfirmPasswordTextbox.TabIndex = 24;
            this.ConfirmPasswordTextbox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTextbox.Visible = false;
            this.ConfirmPasswordTextbox.WordWrap = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ConfirmButton.Location = new System.Drawing.Point(251, 365);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(104, 40);
            this.ConfirmButton.TabIndex = 23;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordLabel.Location = new System.Drawing.Point(144, 219);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(108, 26);
            this.PasswordLabel.TabIndex = 22;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EmailLabel.Location = new System.Drawing.Point(144, 54);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(151, 26);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "Email address";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordTextBox.Location = new System.Drawing.Point(149, 248);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(214, 32);
            this.PasswordTextBox.TabIndex = 20;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Visible = false;
            this.PasswordTextBox.WordWrap = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EmailTextBox.Location = new System.Drawing.Point(149, 83);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 32);
            this.EmailTextBox.TabIndex = 19;
            // 
            // ChangePassword
            // 
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.Location = new System.Drawing.Point(149, 199);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(112, 17);
            this.ChangePassword.TabIndex = 28;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.CheckedChanged += new System.EventHandler(this.ChangePassword_CheckedChanged);
            // 
            // PasswordWarningLabel
            // 
            this.PasswordWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordWarningLabel.AutoSize = true;
            this.PasswordWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordWarningLabel.Location = new System.Drawing.Point(367, 255);
            this.PasswordWarningLabel.Name = "PasswordWarningLabel";
            this.PasswordWarningLabel.Size = new System.Drawing.Size(237, 20);
            this.PasswordWarningLabel.TabIndex = 31;
            this.PasswordWarningLabel.Text = "Password field can not be empty";
            this.PasswordWarningLabel.Visible = false;
            // 
            // EmailWarningLabel
            // 
            this.EmailWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailWarningLabel.AutoSize = true;
            this.EmailWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailWarningLabel.Location = new System.Drawing.Point(369, 90);
            this.EmailWarningLabel.Name = "EmailWarningLabel";
            this.EmailWarningLabel.Size = new System.Drawing.Size(235, 20);
            this.EmailWarningLabel.TabIndex = 30;
            this.EmailWarningLabel.Text = "Email address can not be empty";
            this.EmailWarningLabel.Visible = false;
            // 
            // PasswordsMatchWarningLabel
            // 
            this.PasswordsMatchWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordsMatchWarningLabel.AutoSize = true;
            this.PasswordsMatchWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordsMatchWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordsMatchWarningLabel.Location = new System.Drawing.Point(369, 319);
            this.PasswordsMatchWarningLabel.Name = "PasswordsMatchWarningLabel";
            this.PasswordsMatchWarningLabel.Size = new System.Drawing.Size(203, 20);
            this.PasswordsMatchWarningLabel.TabIndex = 29;
            this.PasswordsMatchWarningLabel.Text = "The passwords must match";
            this.PasswordsMatchWarningLabel.Visible = false;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.PasswordWarningLabel);
            this.Controls.Add(this.EmailWarningLabel);
            this.Controls.Add(this.PasswordsMatchWarningLabel);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.ConfirmPasswordTextbox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "UserSettings";
            this.Text = "Account info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextbox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.CheckBox ChangePassword;
        private System.Windows.Forms.Label PasswordWarningLabel;
        private System.Windows.Forms.Label EmailWarningLabel;
        private System.Windows.Forms.Label PasswordsMatchWarningLabel;
    }
}