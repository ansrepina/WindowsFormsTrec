namespace WindowsFormsTrec
{
    partial class LoginFormNew
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
            this.loginButton = new System.Windows.Forms.Button();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 26.2F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(289, 309);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(125, 57);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 30F);
            this.authorizationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.authorizationLabel.Location = new System.Drawing.Point(390, 85);
            this.authorizationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(235, 60);
            this.authorizationLabel.TabIndex = 1;
            this.authorizationLabel.Text = "Авторизация";
            this.authorizationLabel.Click += new System.EventHandler(this.authorizationLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 26.2F);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginLabel.Location = new System.Drawing.Point(286, 166);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(110, 53);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 26.2F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(286, 229);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(128, 53);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passTextBox.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.passTextBox.Location = new System.Drawing.Point(420, 238);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(294, 44);
            this.passTextBox.TabIndex = 4;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginTextBox.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(420, 175);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(294, 44);
            this.loginTextBox.TabIndex = 5;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 26.2F);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(434, 309);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(280, 57);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // LoginFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.authorizationLabel);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginFormNew";
            this.Text = "LoginFormNew";
            this.Load += new System.EventHandler(this.LoginFormNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button registerButton;
    }
}