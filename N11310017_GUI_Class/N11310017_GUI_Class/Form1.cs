using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310017_GUI_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnButton.Text = "我已經按過ㄌ";
            Form form = new FormButton();
            form.Show(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form formTextBox = new FormTextBox();
            formTextBox.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new FormTimer();
            form.Show();    
        }
    }
}
