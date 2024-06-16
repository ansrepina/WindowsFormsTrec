using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using static WindowsFormsTrec.FormCategories;
using static WindowsFormsTrec.FormPlan;

namespace WindowsFormsTrec
{
    public partial class FormDashbord : Form//, TransactionDataBase
    {
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

        private void table_Click(object sender, EventArgs e)
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

        

        private void buttonOk_Click(object sender, EventArgs e)
        {
           
      
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*//dataBase.OpenFile();
            chartRealFactIncome.Series[0].XValueMember = "план";
            chartRealFactIncome.Series[0].YValueMembers = "план";

            chartRealFactIncome.Series[1].XValueMember = "факт";
            chartRealFactIncome.Series[1].YValueMembers = "факт";

            //  chartRealFactIncome.DataSource = database
            chartRealFactIncome.DataBind();*/
        }
    }
}
