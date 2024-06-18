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
    public partial class FormCategories : Form
    {
        public string accName { get; set; }
        public FormCategories()
        {
            InitializeComponent();
        }
       // TransactionDataBase dataBase = new TransactionDataBase("Test2");
        private void FormCategories_Load(object sender, EventArgs e)
        {
            TransactionDataBase dataBase = new TransactionDataBase(accName);
         
            comboBox1.Items.AddRange(dataBase.OutcomeCategories);
            comboBox1.Items.Add("Новая категория");
          
            comboBox2.Items.AddRange(dataBase.IncomeCategories);
            comboBox2.Items.Add("Новая категория");

            maskedTextBox3.Text = $"    {DateTime.Today.Year}";
            maskedTextBox1.Text = $"    {DateTime.Today.Year}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) //, TransactionDataBase dataBase)
        {

            try
            {
                TransactionDataBase dataBase = new TransactionDataBase(accName);
                dataBase.OpenFile();
                int type = 2; //списание средств
                string date = maskedTextBox3.Text.ToString();
                double value = double.Parse(textBox1.Text);
                string category = comboBox1.Text;
                dataBase.AddNewTransaction(type, category, date, value); 
                dataBase.SaveAndExit();
                MessageBox.Show("Данные успешно добавлены!");

                comboBox1.SelectedIndex = 0;
                textBox1.Clear();
                maskedTextBox3.Clear();
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionDataBase dataBase = new TransactionDataBase(accName);
                dataBase.OpenFile();
                int type = 1; //доходы
                string date = maskedTextBox1.Text.ToString();
                double value = double.Parse(textBox2.Text);
                string category = comboBox2.Text;
                
                dataBase.AddNewTransaction(type, category, date, value);
                dataBase.SaveAndExit();
                MessageBox.Show("Данные успешно добавлены!");

                comboBox2.SelectedIndex = 0;
                textBox2.Clear();
                maskedTextBox1.Clear();
                
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
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Новая категория")
            {

                   // dataBase.AddNewCategory
                    FormAdd form2 = new FormAdd();
                    form2.Tag = this;
                    form2.Show(this);
                    Hide();
            }

            
        }

        private void FormCategories_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
