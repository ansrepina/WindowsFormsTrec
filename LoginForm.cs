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

namespace WindowsFormsTrec
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void mail_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           // OpenClassForm(new FormMain(), sender);
            FormMain form2 = new FormMain();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void LoginForm_Load(object sender, EventArgs e)
=======
        private void panel2_Paint(object sender, PaintEventArgs e)
>>>>>>> d2f5429be9086ac82128739ea0464b7e345370f7
        {

        }
    }
}
