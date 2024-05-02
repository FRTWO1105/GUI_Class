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
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text box 被改變ㄌ");
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = tbInput.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox2.Text);
            int z = Int32.Parse(textBox3.Text);
            label4.Text = (a+z).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox2.Text);
            int z = Int32.Parse(textBox3.Text);
            label4.Text = (a + z).ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox4.Text);
            int z = Int32.Parse(textBox5.Text);
            label13.Text = (a - z).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox9.Text);
            int z = Int32.Parse(textBox7.Text);
            label10.Text = (a * z).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Int32.Parse(textBox8.Text);
            double z = Int32.Parse(textBox6.Text);
            label12.Text = (a / z).ToString();
        }
    
    

   
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox2.Text);
            int z = Int32.Parse(textBox3.Text);
            label4.Text = (a + z).ToString();
        }
    }
}

