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
        public FormCategories()
        {
            InitializeComponent();
        }
       // TransactionDataBase dataBase = new TransactionDataBase("Test2");
        private void FormCategories_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Продукты");
            comboBox1.Items.Add("Транспорт");
            comboBox1.Items.Add("Одежда и обувь");
            comboBox1.Items.Add("Новая категория");

            comboBox2.Items.Add("Зарплата");
            comboBox2.Items.Add("Транспорт");
            comboBox2.Items.Add("Одежда и обувь");
            comboBox2.Items.Add("Другое");

            /*string[] aboba = { "hfpd", "asd", "bang", "New" };
            comboBox1.Items.AddRange(aboba);*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) //, TransactionDataBase dataBase)
        {

            try
            {
                TransactionDataBase dataBase = new TransactionDataBase("Test3");
                int type = 2; //списание средств
                string category = "1"; // comboBox1.Text.ToString(); //изменить, чтобы категория записывалась под цифру 1
                string date = maskedTextBox3.Text.ToString();
                double value = double.Parse(textBox1.Text);

                dataBase.AddNewTransaction(type, category, date, value); //  вызов метода
                dataBase.CloseFile();
                MessageBox.Show("Данные успешно добавлены!");

                comboBox1.SelectedIndex = 0;
                textBox1.Clear();
                maskedTextBox3.Clear();
                comboBox1.SelectedIndex = 0;
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
        /*private void comboBox1_Loaded(object sender, EventArgs e)
        {
            string[] aboba = { "hfpd", "asd", "bang" };
            FormCategories.comboBox1.Items.AddRange(aboba);
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string[] aboba = { "hfpd", "asd", "bang" };
            FormCategories.comboBox1.Items.AddRange(aboba);*/

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Новая категория")
            {

                   // dataBase.AddNewCategory
                    FormMain form2 = new FormMain();
                    form2.Tag = this;
                    form2.Show(this);
                    Hide();
            }

            
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void FormCategories_ParentChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
