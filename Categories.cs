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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        public TransactionDataBase DataBase { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e) //, TransactionDataBase dataBase)
        {
            int type = 1;
            string category = textBox1.Text;
            string date = "00.00.0000"; //DateTime.Today.ToShortStringDate();
            double value = 4;
            DataBase.AddNewTransaction(type, category, date, value);// int type, string category, string date, double value*/
        }
    }
}
