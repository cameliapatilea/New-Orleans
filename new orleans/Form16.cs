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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mod = new Form13();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mod = new Form2();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mod = new Form17();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }
    }
}
