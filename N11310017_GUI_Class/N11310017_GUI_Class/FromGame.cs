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
    public partial class FromGame : Form
    {
        public FromGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int result=r.Next(100);
            MessageBox.Show(result.ToString());
        }
    }
}
