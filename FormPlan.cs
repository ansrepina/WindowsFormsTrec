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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsTrec
{
    public partial class FormPlan : Form
    {
        public string accName { get; set; }
        public FormPlan()
        {
            InitializeComponent();
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            TransactionDataBase dataBase = new TransactionDataBase(accName);

            comboBox4.Items.Add(dataBase.OutcomeCategories);
            comboBox4.Items.Add("Новая категория");
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
