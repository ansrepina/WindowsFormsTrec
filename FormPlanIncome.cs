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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            comboBox4.Items.AddRange(dataBase.IncomeCategories);
            comboBox4.Items.Add("Новая категория");


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Новая категория")
            {

                // dataBase.AddNewCategory
                FormAdd2 form2 = new FormAdd2();
                form2.Tag = this;
                form2.Show(this);
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionDataBase dataBase = new TransactionDataBase(accName);
                dataBase.OpenFile();
                string month = comboBox2.Text.ToString();
                string category = comboBox4.Text.ToString();
                double value = double.Parse(maskedTextBox4.Text);
                dataBase.EditPlan(month, category, value);
                dataBase.SaveAndExit();
                MessageBox.Show("Данные успешно добавлены!");

                comboBox2.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                maskedTextBox4.Clear();


            }
            catch (ArgumentException ex)
            {
                // Обработка исключения
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Обработка других исключений
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
