namespace WindowsFormsTrec
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonCategory = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenu.SuspendLayout();
            this.TopPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonHelp.Location = new System.Drawing.Point(0, 411);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(260, 32);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "ПОМОЩЬ";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\User\\Downloads\\help.chm";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Tan;
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.ButtonCategory);
            this.panelMenu.Controls.Add(this.ButtonHome);
            this.panelMenu.Controls.Add(this.TopPanel);
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 443);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.Location = new System.Drawing.Point(0, 207);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(260, 51);
            this.buttonSetting.TabIndex = 5;
            this.buttonSetting.Text = "Настройки";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отчет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCategory.Location = new System.Drawing.Point(0, 111);
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(260, 48);
            this.ButtonCategory.TabIndex = 3;
            this.ButtonCategory.Text = "Транзакции";
            this.ButtonCategory.UseVisualStyleBackColor = true;
            this.ButtonCategory.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHome.Location = new System.Drawing.Point(0, 63);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(260, 48);
            this.ButtonHome.TabIndex = 2;
            this.ButtonHome.Text = "Дашборд";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(260, 63);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // TopPanelTitle
            // 
            this.TopPanelTitle.BackColor = System.Drawing.Color.BurlyWood;
            this.TopPanelTitle.Controls.Add(this.label1);
            this.TopPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopPanelTitle.Location = new System.Drawing.Point(260, 0);
            this.TopPanelTitle.Name = "TopPanelTitle";
            this.TopPanelTitle.Size = new System.Drawing.Size(810, 63);
            this.TopPanelTitle.TabIndex = 2;
            this.TopPanelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanelLeft_Paint);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.White;
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(260, 63);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(810, 380);
            this.panelDesktopPanel.TabIndex = 6;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1070, 443);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.TopPanelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "Trecer";
            this.panelMenu.ResumeLayout(false);
            this.TopPanelTitle.ResumeLayout(false);
            this.TopPanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonCategory;
        protected System.Windows.Forms.Button buttonHelp;
        protected System.Windows.Forms.Panel TopPanelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

