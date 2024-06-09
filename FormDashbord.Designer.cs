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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRealFactIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.table = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxGeneralExpenses = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartRealFactIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRealFactIncome
            // 
            chartArea10.Name = "ChartArea1";
            this.chartRealFactIncome.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartRealFactIncome.Legends.Add(legend10);
            this.chartRealFactIncome.Location = new System.Drawing.Point(16, 183);
            this.chartRealFactIncome.Name = "chartRealFactIncome";
            this.chartRealFactIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartRealFactIncome.Series.Add(series10);
            this.chartRealFactIncome.Size = new System.Drawing.Size(544, 157);
            this.chartRealFactIncome.TabIndex = 0;
            this.chartRealFactIncome.Text = "Ожидание - реальность";
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.Name = "Title1";
            this.chartRealFactIncome.Titles.Add(title7);
            this.chartRealFactIncome.Click += new System.EventHandler(this.chartRealFact_Click);
            // 
            // chartExpenses
            // 
            this.chartExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea11.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend11);
            this.chartExpenses.Location = new System.Drawing.Point(586, 183);
            this.chartExpenses.Name = "chartExpenses";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartExpenses.Series.Add(series11);
            this.chartExpenses.Size = new System.Drawing.Size(406, 332);
            this.chartExpenses.TabIndex = 1;
            this.chartExpenses.Text = "chart2";
            this.chartExpenses.Click += new System.EventHandler(this.chart2_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.dateTimePicker3);
            this.panelHome.Controls.Add(this.dateTimePicker2);
            this.panelHome.Controls.Add(this.buttonOk);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1082, 56);
            this.panelHome.TabIndex = 2;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMM, yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
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
            // table
            // 
            chartArea12.Name = "ChartArea1";
            this.table.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.table.Legends.Add(legend12);
            this.table.Location = new System.Drawing.Point(16, 363);
            this.table.Name = "table";
            this.table.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.table.Series.Add(series12);
            this.table.Size = new System.Drawing.Size(544, 152);
            this.table.TabIndex = 3;
            this.table.Text = "Ожидание - реальность";
            title8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title8.Name = "Title1";
            this.table.Titles.Add(title8);
            this.table.Click += new System.EventHandler(this.table_Click);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(72, 29);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 22);
            this.textBoxBalance.TabIndex = 4;
            this.textBoxBalance.TextChanged += new System.EventHandler(this.textBoxBalance_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 86);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxGeneralExpenses
            // 
            this.textBoxGeneralExpenses.Location = new System.Drawing.Point(62, 29);
            this.textBoxGeneralExpenses.Name = "textBoxGeneralExpenses";
            this.textBoxGeneralExpenses.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeneralExpenses.TabIndex = 5;
            this.textBoxGeneralExpenses.TextChanged += new System.EventHandler(this.textBoxGeneralExpenses_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxBalance);
            this.panel2.Location = new System.Drawing.Point(89, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 71);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxGeneralExpenses);
            this.panel3.Location = new System.Drawing.Point(550, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 71);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tекущий баланс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расходы:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "месяц"});
            this.listBox1.Location = new System.Drawing.Point(869, 495);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 20);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(437, 495);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(123, 20);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(437, 320);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(123, 20);
            this.listBox3.TabIndex = 9;
            // 
            // FormDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 637);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.chartExpenses);
            this.Controls.Add(this.chartRealFactIncome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormDashbord";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRealFactIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGeneralExpenses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}