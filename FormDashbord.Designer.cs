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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRealFactIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transactionDataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHome = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5I = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRealFactIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRealFactIncome
            // 
            this.chartRealFactIncome.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.Name = "ChartArea1";
            this.chartRealFactIncome.ChartAreas.Add(chartArea10);
            this.chartRealFactIncome.DataSource = this.transactionDataBaseBindingSource;
            legend10.Name = "Legend1";
            this.chartRealFactIncome.Legends.Add(legend10);
            this.chartRealFactIncome.Location = new System.Drawing.Point(12, 144);
            this.chartRealFactIncome.Name = "chartRealFactIncome";
            this.chartRealFactIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRealFactIncome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series16.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series16.BackImageTransparentColor = System.Drawing.Color.White;
            series16.BorderColor = System.Drawing.Color.White;
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series16.LabelBackColor = System.Drawing.Color.Fuchsia;
            series16.Legend = "Legend1";
            series16.MarkerColor = System.Drawing.Color.Olive;
            series16.MarkerSize = 4;
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series16.Name = "План";
            series16.ShadowColor = System.Drawing.Color.White;
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series17.Legend = "Legend1";
            series17.Name = "Факт";
            this.chartRealFactIncome.Series.Add(series16);
            this.chartRealFactIncome.Series.Add(series17);
            this.chartRealFactIncome.Size = new System.Drawing.Size(392, 149);
            this.chartRealFactIncome.TabIndex = 0;
            this.chartRealFactIncome.Text = "Ожидание - реальность по расходам";
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.Name = "Title1";
            title7.Text = "План / Факт расходов";
            this.chartRealFactIncome.Titles.Add(title7);
            this.chartRealFactIncome.Click += new System.EventHandler(this.chartRealFact_Click);
            this.chartRealFactIncome.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chartRealFactIncome_MouseDoubleClick);
            // 
            // transactionDataBaseBindingSource
            // 
            this.transactionDataBaseBindingSource.CurrentChanged += new System.EventHandler(this.transactionDataBaseBindingSource_CurrentChanged);
            // 
            // chartExpenses
            // 
            this.chartExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chartExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chartExpenses.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartExpenses.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartExpenses.BackSecondaryColor = System.Drawing.Color.White;
            chartArea11.BorderColor = System.Drawing.Color.Maroon;
            chartArea11.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend11);
            this.chartExpenses.Location = new System.Drawing.Point(392, 164);
            this.chartExpenses.Name = "chartExpenses";
            this.chartExpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series18.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series18.BackSecondaryColor = System.Drawing.Color.Lime;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series18.LabelForeColor = System.Drawing.Color.Transparent;
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chartExpenses.Series.Add(series18);
            this.chartExpenses.Size = new System.Drawing.Size(377, 284);
            this.chartExpenses.TabIndex = 1;
            this.chartExpenses.Text = "ыы";
            this.chartExpenses.Click += new System.EventHandler(this.chart2_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.Controls.Add(this.button2);
            this.panelHome.Controls.Add(this.button1);
            this.panelHome.Controls.Add(this.dateTimePicker3);
            this.panelHome.Controls.Add(this.dateTimePicker2);
            this.panelHome.Controls.Add(this.buttonOk);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(793, 44);
            this.panelHome.TabIndex = 2;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(510, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "неделя";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(633, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "месяц";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd MMM, yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(237, 9);
            this.dateTimePicker3.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 4;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Beige;
            this.dateTimePicker2.CustomFormat = "dd MMM, yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(23, 9);
            this.dateTimePicker2.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Yellow;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(443, 8);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(61, 29);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "ок";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 79);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.label5I);
            this.panel4.Controls.Add(this.label6);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(370, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 66);
            this.panel4.TabIndex = 9;
            // 
            // label5I
            // 
            this.label5I.AutoSize = true;
            this.label5I.Font = new System.Drawing.Font("Gentium Basic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5I.Location = new System.Drawing.Point(16, 29);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(193, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 66);
            this.panel3.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расходы:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelBalance);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 66);
            this.panel2.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Баланс:";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            this.chart1.DataSource = this.transactionDataBaseBindingSource;
            legend12.Name = "Legend1";
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(12, 299);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series19.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series19.BackImageTransparentColor = System.Drawing.Color.White;
            series19.BorderColor = System.Drawing.Color.White;
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series19.LabelBackColor = System.Drawing.Color.Fuchsia;
            series19.Legend = "Legend1";
            series19.MarkerColor = System.Drawing.Color.Olive;
            series19.MarkerSize = 4;
            series19.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series19.Name = "План";
            series19.ShadowColor = System.Drawing.Color.White;
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series20.Legend = "Legend1";
            series20.Name = "Факт";
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Size = new System.Drawing.Size(392, 149);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "Ожидание - реальность по расходам";
            title8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title8.Name = "Title1";
            title8.Text = "План / Факт доходов";
            this.chart1.Titles.Add(title8);
            // 
            // FormDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.chartExpenses);
            this.Controls.Add(this.chartRealFactIncome);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FormDashbord";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRealFactIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRealFactIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5I;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource transactionDataBaseBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}