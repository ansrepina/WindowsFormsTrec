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
           // this.DataBase.Fill(this.)
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*public object[,] rangeCircleDiagramData(string date1, string date2) //Данные для круговой диаграммы, расходы по 
        {
            object[,] circleDiagramData = new object[2, outcomeEnding - outcomeBegining];

            for (int i = 0; i < circleDiagramData.GetLength(1); i++)
            {
                circleDiagramData[0, i] = OutcomeCategories[i];
            }

            for (int i = 0; i < circleDiagramData.GetLength(1); i++)
            {
                circleDiagramData[1, i] = SumColumnByDates(date1, date2, outcomeBegining + i + 1);
            }
            return circleDiagramData;
        }*/

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //SeriesCollection series = new SeriesCollection();
            string date1 = dateTimePickerStart.Value.ToString(); //стартовое значение
            string date2 = dateTimePickerEnd.Value.ToString(); //конечное значение
            Dictionary<string, double> chartSource = new Dictionary<string, double>();
            TransactionDataBase dataBase = new TransactionDataBase(accName);
            dataBase.OpenFile();
            object[,] diagram = dataBase.rangeCircleDiagramData(date1, date2);
            for( int i = 0; i < diagram.GetLength(1); i++)
            {
                chartSource.Add(diagram[0, i].ToString(), double.Parse(diagram[1, i].ToString()));
            }
            chartExpenses.Series.Clear();
            chartExpenses.Series.Add("pie");
            chartExpenses.Series["pie"].ChartType = SeriesChartType.Pie;
            chartExpenses.Series["pie"].Points.DataBindXY(chartSource.Keys, chartSource.Values);
        }
            //SeriesCollection series = new SeriesCollection();
            


            /*string start = dateTimePickerStart.Value.ToString(); //стартовое значение
            string end = dateTimePickerEnd.Value.ToString(); //конечное значение
                                                             //dataBase.OpenFile();
            

            chartRealFactIncome.Series[0].XValueMember = "план";
            chartRealFactIncome.Series[0].YValueMembers = "план";

            chartRealFactIncome.Series[1].XValueMember = "факт";
            chartRealFactIncome.Series[1].YValueMembers = "факт";

            //  chartRealFactIncome.DataSource = database
            chartRealFactIncome.DataBind();*/



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e) //, TransactionDataBase dataBase)
        {
           
        }

        

        private void transactionDataBaseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
