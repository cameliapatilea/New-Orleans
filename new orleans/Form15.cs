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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mod = new Form14();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form mod = new Form13();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mod = new Form2();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mod = new Form16();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }
    }
}
