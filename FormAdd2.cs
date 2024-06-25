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
    public partial class FormAdd2 : Form
    {
        public string accName { get; set; }
        public FormAdd2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionDataBase dataBase = new TransactionDataBase(accName);
            dataBase.OpenFile();
            string name = textBox1.Text;
            int option = 1;
            dataBase.AddNewCategory(name, option);
            dataBase.SaveAndExit();
            MessageBox.Show("Категория добавлена!");
            textBox1.Clear();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();        
        }

        private void FormAdd2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
