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
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Form activeForm;
        private const string helpfile = "help.chm";
        public FormMain()
        {
            InitializeComponent();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpfile);
        }*/
        
        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = @"C:\Users\User\Downloads\help.chm";

            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
        private void ActivateButton(object btnSender)
        {            
            if (btnSender != null)
            { 
                currentButton = (Button)btnSender;
               // currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            /*{
                if (currentButton != (Button)btnSender)
                {
                 //  DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                   // panelTitleBar.BackColor = color;
                  //  panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                  //  btnCloseChildForm.Visible = true;
                }
            }*/
        }
        
       
        private void OpenClassForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; //расположение формы на экране
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e) 
        {
            OpenClassForm(new FormDashbord(), sender);

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            OpenClassForm(new FormCategories(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TopPanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

