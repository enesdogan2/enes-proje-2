﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               listBox1.Items.Add("Lambalar Açık");  
            }
            else
                listBox1.Items.Add("Lambalar Kapalı"); 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox2.Checked == true)
            {
               listBox1.Items.Add("Kombi Açık");  
            }
            else
                listBox1.Items.Add("Kombi Kapalı"); 
        }
    }
}
