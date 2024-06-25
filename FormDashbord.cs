using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataBase;
using static WindowsFormsTrec.FormPlan;

namespace WindowsFormsTrec
{
    public partial class FormDashbord : Form  //, TransactionDataBase
    {
        public string accName { get; set; }
        public FormDashbord()
        {
            InitializeComponent();
            
        }
        private void BalanceOutput(object sender, LayoutEventArgs e) //вывод баланса из базы данных на печать в виде итоговой суммы (int)
        {

        }
        private void GeneralExpensesOutput(object sender, LayoutEventArgs e) //вывод дохода из базы данных на печать
        {

        }

        private void TotalProfitOutput(object sender, LayoutEventArgs e) //вывод прибыли
        {

        }
      
        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }
        private void chartRealFact_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToShortDateString();
            
            Dictionary<string, double> chartSource = new Dictionary<string, double>();
            TransactionDataBase dataBase = new TransactionDataBase(accName);
            dataBase.OpenFile();
            object[,] diagram = dataBase.rangeCircleDiagramData(today, today);
            for (int i = 0; i < diagram.GetLength(1); i++)
            {
                chartSource.Add(diagram[0, i].ToString() + " " + diagram[1, i].ToString(), double.Parse(diagram[1, i].ToString()));
            }
            chartExpenses.Series.Clear();
            chartExpenses.Series.Add("pie");
            chartExpenses.Series["pie"].ChartType = SeriesChartType.Pie;
            chartExpenses.Series["pie"].Points.DataBindXY(chartSource.Keys, chartSource.Values);
            //вывод в панель
            double[] outt1 = dataBase.IncomeOutcomeSaldo(today, today);
            labelIncome.Text = outt1[0].ToString();
            labelExpenses.Text = outt1[1].ToString();
            labelSaldo.Text = outt1[2].ToString();

            //вывод данных таблицы план/факт доходов
            double[,] table = dataBase.IncomePlanFactDiagramData();
            double[] y1Val = new double[12];
            double[] y2Val = new double[12];
            for (int i = 0; i < 12; i++)
            {
                y1Val[i] = table[0, i];
                y2Val[i] = table[1, i];
            }
            string[] xVal = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            chartRealFactIncome.Series.Clear();

            Series s1 = new Series("План") { ChartType = SeriesChartType.Spline };
            Series s2 = new Series("Факт") { ChartType = SeriesChartType.Spline };
            s1.Points.DataBindXY(xVal, y1Val);
            s2.Points.DataBindXY(xVal, y2Val);

            chartRealFactIncome.Series.Add(s1);
            chartRealFactIncome.Series.Add(s2);


            //вывод данных таблицы план/факт расходов
            double[,] table2 = dataBase.OutcomePlanFactDiagramData();
            double[] y1Val2 = new double[12];
            double[] y2Val2 = new double[12];
            for (int i = 0; i < 12; i++)
            {
                y1Val2[i] = table2[0, i];
                y2Val2[i] = table2[1, i];
            }
            chart1.Series.Clear();

            Series s12 = new Series("План") { ChartType = SeriesChartType.Spline };
            Series s22 = new Series("Факт") { ChartType = SeriesChartType.Spline };
            s12.Points.DataBindXY(xVal, y1Val2);
            s22.Points.DataBindXY(xVal, y2Val2);

            chart1.Series.Add(s12);
            chart1.Series.Add(s22);

            dataBase.CloseFile();

        }

        private void chart2_Click(object sender, EventArgs e)
        {
       
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chartRealFactIncome_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString(); //стартовое значение
            string date2 = dateTimePickerEnd.Value.ToString(); //конечное значение
            Dictionary<string, double> chartSource = new Dictionary<string, double>();
            TransactionDataBase dataBase = new TransactionDataBase(accName);
            dataBase.OpenFile();

            object[,] diagram = dataBase.rangeCircleDiagramData(date1, date2);
            for( int i = 0; i < diagram.GetLength(1); i++)
            {
                chartSource.Add(diagram[0, i].ToString() + " " + diagram[1, i].ToString(), double.Parse(diagram[1, i].ToString()));
            }
            chartExpenses.Series.Clear();
            chartExpenses.Series.Add("pie");
            chartExpenses.Series["pie"].ChartType = SeriesChartType.Pie;
            chartExpenses.Series["pie"].Points.DataBindXY(chartSource.Keys, chartSource.Values);

            //вывод в панель
            double[] outt = dataBase.IncomeOutcomeSaldo(date1, date2);
            labelIncome.Text = outt[0].ToString();
            labelExpenses.Text = outt[1].ToString();
            labelSaldo.Text = outt[2].ToString();

            //вывод данных таблицы план/факт доходов
            double[,] table = dataBase.IncomePlanFactDiagramData();
            double[] y1Val = new double[12];
            double[] y2Val = new double[12];
            for (int i = 0; i < 12; i++)
            {
                y1Val[i] = table[0, i];
                y2Val[i] = table[1, i];
            }
            string[] xVal = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            chartRealFactIncome.Series.Clear();

            Series s1 = new Series("План") { ChartType = SeriesChartType.Spline };
            Series s2 = new Series("Факт") { ChartType = SeriesChartType.Spline };
            s1.Points.DataBindXY(xVal, y1Val);
            s2.Points.DataBindXY(xVal, y2Val);

            chartRealFactIncome.Series.Add(s1);
            chartRealFactIncome.Series.Add(s2);


            //вывод данных таблицы план/факт расходов
            double[,] table2 = dataBase.OutcomePlanFactDiagramData();
            double[] y1Val2 = new double[12];
            double[] y2Val2 = new double[12];
            for (int i = 0; i < 12; i++)
            {
                y1Val2[i] = table2[0, i];
                y2Val2[i] = table2[1, i];
            }
            chart1.Series.Clear();

            Series s12 = new Series("План") { ChartType = SeriesChartType.Spline };
            Series s22 = new Series("Факт") { ChartType = SeriesChartType.Spline };
            s12.Points.DataBindXY(xVal, y1Val2);
            s22.Points.DataBindXY(xVal, y2Val2);

            chart1.Series.Add(s12);
            chart1.Series.Add(s22);

            dataBase.CloseFile();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void transactionDataBaseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
