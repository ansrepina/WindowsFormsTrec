using MySql.Data.MySqlClient;
using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrec
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passTextBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists())
            {
                return;
            }

            LoginDataBase dataBase = new LoginDataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", dataBase.getConnection()); //записываем данные в таблицу

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passTextBox.Text;

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                TransactionDataBase excel = new TransactionDataBase(loginTextBox.Text, 1);
                MessageBox.Show("Вы зарегистрировались");
                LoginFormNew form2 = new LoginFormNew();
                form2.Tag = this;
                form2.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Вы не зарегистрировались");
                loginTextBox.Clear();
                passTextBox.Clear();
            }

            dataBase.closeConnection();
        }
        public Boolean isUserExists()
        {
            LoginDataBase dataBase = new LoginDataBase();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @loginUser", dataBase.getConnection()); //создаём объект, который позволит прописать команду для выборки данных из базы данных
            command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginTextBox.Text;

            adapter.SelectCommand = command; //адаптер позволяет выбрать данные из БД
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
