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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpfile);
        }*/
        private const string helpfile = "help.chm";
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = @"C:\Users\User\Downloads\help.chm";

            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

