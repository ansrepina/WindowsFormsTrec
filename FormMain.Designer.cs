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
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonCategory = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelTitle = new System.Windows.Forms.Panel();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(0, 505);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(240, 32);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\User\\Downloads\\help.chm";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SeaShell;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.ButtonCategory);
            this.panelMenu.Controls.Add(this.ButtonHome);
            this.panelMenu.Controls.Add(this.TopPanel);
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 537);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Планирование расходов";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ButtonCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCategory.Location = new System.Drawing.Point(0, 105);
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(240, 48);
            this.ButtonCategory.TabIndex = 3;
            this.ButtonCategory.Text = "Ввод транзакций";
            this.ButtonCategory.UseVisualStyleBackColor = false;
            this.ButtonCategory.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHome.Location = new System.Drawing.Point(0, 57);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(240, 48);
            this.ButtonHome.TabIndex = 2;
            this.ButtonHome.Text = "Дашборд";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(240, 57);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // TopPanelTitle
            // 
            this.TopPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopPanelTitle.Location = new System.Drawing.Point(240, 0);
            this.TopPanelTitle.Name = "TopPanelTitle";
            this.TopPanelTitle.Size = new System.Drawing.Size(797, 57);
            this.TopPanelTitle.TabIndex = 2;
            this.TopPanelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanelLeft_Paint);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.OldLace;
            this.panelDesktopPanel.Controls.Add(this.panel1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(240, 57);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(797, 480);
            this.panelDesktopPanel.TabIndex = 6;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 480);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Трекер Расходов";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Планирование доходов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1037, 537);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.TopPanelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "Trecer";
            this.panelMenu.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonCategory;
        protected System.Windows.Forms.Button buttonHelp;
        protected System.Windows.Forms.Panel TopPanelTitle;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

