using DataBase;
using MySql.Data.MySqlClient;
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
    public partial class LoginFormNew : Form
    {
        public LoginFormNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String loginUser = loginTextBox.Text; //присваиваем переменной данные, введённые пользователем
            String passUser = passTextBox.Text;

            LoginDataBase dataBase = new LoginDataBase();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @loginUser AND `password` = @passUser", dataBase.getConnection()); //создаём объект, который позволит прописать команду для выборки данных из базы данных
            command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command; //адаптер позволяет выбрать данные из БД
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Вы авторизовались");
                FormMain formMain = new FormMain();
                formMain.accName = loginUser;
                formMain.Tag = this;
                formMain.Show(this);
                Hide();


            }

            else
            {
                MessageBox.Show("Вы не авторизовались");
                loginTextBox.Clear();
                passTextBox.Clear();
            }
                
                
        }

        private void LoginFormNew_Load(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorizationLabel_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm form2 = new RegisterForm();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LoginFormNew
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "LoginFormNew";
            this.Load += new System.EventHandler(this.LoginFormNew_Load_1);
            this.ResumeLayout(false);

        }

        private void LoginFormNew_Load_1(object sender, EventArgs e)
        {

        }
    }
}
