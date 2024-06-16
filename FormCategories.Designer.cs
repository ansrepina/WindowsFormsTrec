namespace WindowsFormsTrec
{
    partial class FormCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       /* private System.EventHandler GetEventHandler()
        {
            return new System.EventHandler(this.buttonExpenseOk_Click);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(System.EventHandler eventHandler)
        {
            this.SuspendLayout();
            // 
            // FormCategories
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FormCategories";
            this.Load += new System.EventHandler(this.FormCategories_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource transactionDataBaseBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExpenseOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonIncomeOk;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}