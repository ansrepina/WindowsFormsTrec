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
        private int borderSize = 2;
       // private Size formSize;
        public FormMain()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//размер
           // this.BackColor = Color.FromArgb(98, 102, 244);
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

            /*if (btnSender != null)
            {
                currentButton = (Button)btnSender;
                
            }*/
            if (btnSender != null)
            { 
                currentButton = (Button)btnSender;
                 currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            {
                if (currentButton != (Button)btnSender)
                {
                 //  DisableButton();
                    Color color = Color.FromArgb(87, 150, 78);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    TopPanel.BackColor = color;
                   // panel1.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                   // ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                  //  btnCloseChildForm.Visible = true;
                }
            }
        }
        /*private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }*/


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
        private void btnCloseClassForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()

        {
            DisableButton();
            TopPanel.Text = "HOME";
            TopPanel.BackColor = Color.FromArgb(0, 150, 136);
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
          //  btnCloseChildForm.Visible = false;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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

        private void TopPanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenClassForm(new FormPlan(), sender);
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

