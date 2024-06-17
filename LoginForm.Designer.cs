namespace WindowsFormsTrec
{
    partial class LoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.registerButton);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.mailTextBox);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.mail);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 661);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.registerButton.Location = new System.Drawing.Point(465, 342);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(295, 48);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.loginButton.Location = new System.Drawing.Point(310, 342);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 48);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(420, 279);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '.';
            this.passwordTextBox.Size = new System.Drawing.Size(340, 47);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mailTextBox.Enabled = false;
            this.mailTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailTextBox.Location = new System.Drawing.Point(420, 217);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(340, 47);
            this.mailTextBox.TabIndex = 7;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.password.AutoSize = true;
            this.password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.password.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.password.Location = new System.Drawing.Point(303, 277);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(116, 41);
            this.password.TabIndex = 6;
            this.password.Text = "Пароль";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.name.Location = new System.Drawing.Point(303, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 41);
            this.name.TabIndex = 5;
            this.name.Text = "Имя";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mail.AutoSize = true;
            this.mail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mail.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mail.Location = new System.Drawing.Point(303, 217);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(97, 41);
            this.mail.TabIndex = 2;
            this.mail.Text = "Почта";
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nameTextBox.Location = new System.Drawing.Point(420, 158);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(340, 47);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(466, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Авторизация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 661);
            this.panel1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1047, 661);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}