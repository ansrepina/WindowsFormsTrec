namespace WindowsFormsTrec
{
    partial class FormDashbord
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRealFactIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHome = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5I = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRealFactIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRealFactIncome
            // 
            this.chartRealFactIncome.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea13.Name = "ChartArea1";
            this.chartRealFactIncome.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartRealFactIncome.Legends.Add(legend13);
            this.chartRealFactIncome.Location = new System.Drawing.Point(16, 193);
            this.chartRealFactIncome.Name = "chartRealFactIncome";
            this.chartRealFactIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series13.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series13.BackImageTransparentColor = System.Drawing.Color.White;
            series13.BorderColor = System.Drawing.Color.White;
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series13.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series13.Legend = "Legend1";
            series13.MarkerColor = System.Drawing.Color.OliveDrab;
            series13.MarkerSize = 4;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "Series1";
            series13.ShadowColor = System.Drawing.Color.White;
            series13.YValuesPerPoint = 2;
            this.chartRealFactIncome.Series.Add(series13);
            this.chartRealFactIncome.Size = new System.Drawing.Size(544, 157);
            this.chartRealFactIncome.TabIndex = 0;
            this.chartRealFactIncome.Text = "Ожидание - реальность по расходам";
            title9.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title9.Name = "Title1";
            title9.Text = "План / Факт расходов";
            this.chartRealFactIncome.Titles.Add(title9);
            this.chartRealFactIncome.Click += new System.EventHandler(this.chartRealFact_Click);
            // 
            // chartExpenses
            // 
            this.chartExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chartExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chartExpenses.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartExpenses.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend14);
            this.chartExpenses.Location = new System.Drawing.Point(595, 183);
            this.chartExpenses.Name = "chartExpenses";
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series14.BackSecondaryColor = System.Drawing.Color.Lime;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartExpenses.Series.Add(series14);
            this.chartExpenses.Size = new System.Drawing.Size(516, 390);
            this.chartExpenses.TabIndex = 1;
            this.chartExpenses.Text = "Траты";
            this.chartExpenses.Click += new System.EventHandler(this.chart2_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Silver;
            this.panelHome.Controls.Add(this.dateTimePicker3);
            this.panelHome.Controls.Add(this.dateTimePicker2);
            this.panelHome.Controls.Add(this.buttonOk);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1136, 56);
            this.panelHome.TabIndex = 2;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd MMM, yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(218, 9);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 4;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMM, yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(424, 8);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.table.BorderlineColor = System.Drawing.Color.Gray;
            chartArea15.Name = "ChartArea1";
            this.table.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.table.Legends.Add(legend15);
            this.table.Location = new System.Drawing.Point(16, 409);
            this.table.Name = "table";
            this.table.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series15.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series15.BackSecondaryColor = System.Drawing.Color.White;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series15.IsXValueIndexed = true;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            series15.YValuesPerPoint = 2;
            this.table.Series.Add(series15);
            this.table.Size = new System.Drawing.Size(544, 152);
            this.table.TabIndex = 3;
            this.table.Text = "Ожидание - реальность";
            title10.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title10.Name = "Title1";
            this.table.Titles.Add(title10);
            this.table.Click += new System.EventHandler(this.table_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 106);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(228, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 75);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расходы:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.labelBalance);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 75);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Баланс:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "месяц"});
            this.listBox1.Location = new System.Drawing.Point(884, 541);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 20);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(437, 541);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(123, 20);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(437, 330);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(123, 20);
            this.listBox3.TabIndex = 9;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Gentium Basic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(6, 29);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(84, 32);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "10000";
            this.labelBalance.Click += new System.EventHandler(this.label3_Click);
            this.labelBalance.Layout += new System.Windows.Forms.LayoutEventHandler(this.BalanceOutput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gentium Basic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "10000";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.Layout += new System.Windows.Forms.LayoutEventHandler(this.GeneralExpensesOutput);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label5I);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(456, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(655, 75);
            this.panel4.TabIndex = 9;
            // 
            // label5I
            // 
            this.label5I.AutoSize = true;
            this.label5I.Font = new System.Drawing.Font("Gentium Basic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5I.Location = new System.Drawing.Point(19, 29);
            this.label5I.Name = "label5I";
            this.label5I.Size = new System.Drawing.Size(84, 32);
            this.label5I.TabIndex = 8;
            this.label5I.Text = "10000";
            this.label5I.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Общая прибыль:";
            this.label6.Layout += new System.Windows.Forms.LayoutEventHandler(this.TotalProfitOutput);
            // 
            // FormDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1136, 650);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.chartExpenses);
            this.Controls.Add(this.chartRealFactIncome);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.Name = "FormDashbord";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRealFactIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRealFactIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DataVisualization.Charting.Chart table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5I;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}