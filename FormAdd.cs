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
    public partial class FormAdd : Form
    {
        public string accName { get; set; }
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionDataBase dataBase = new TransactionDataBase(accName);
            dataBase.OpenFile();
            string name = textBox1.Text;
            int option = 2;
            dataBase.AddNewCategory(name, option);
            dataBase.SaveAndExit();
            MessageBox.Show("Категория добавлена!");
            textBox1.Clear();
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
