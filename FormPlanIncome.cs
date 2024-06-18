using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrec
{
    public partial class FormPlanIncome : Form
    {
        public string accName { get; set; }
        public FormPlanIncome()
        {
            InitializeComponent();
        }

        private void FormPlanIncome_Load(object sender, EventArgs e)
        {
            TransactionDataBase dataBase = new TransactionDataBase(accName);

            comboBox4.Items.Add(dataBase.IncomeCategories);
            comboBox4.Items.Add("Новая категория");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
