﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consecutivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            int consecutivo;
            consecutivo = Convert.ToInt32(textBox1.Text);

            for (i = 0; i <=  consecutivo; i++)
{

                listBox1.Items.Add(i);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
