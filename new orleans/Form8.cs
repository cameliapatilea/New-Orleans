﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new_orleans
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mod = new Form7();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mod = new Form10();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }
    }
}
