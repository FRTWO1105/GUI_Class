﻿using System;
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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經按過ㄌ";
            else if (btnClick.Text == "我已經被按過ㄌ")
                btnClick.Text = "請按我一下";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕已被按過";
            label1.Size = new System.Drawing.Size(150, 30);
            label1.BackColor = System.Drawing.Color.Blue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = label2.Text;
            int sum = Int32.Parse(tmp)+1;
            label2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tmp = label2.Text;
            int sum = Int32.Parse(tmp)-1;
            label2.Text = sum.ToString();
        }
    }
    
}
