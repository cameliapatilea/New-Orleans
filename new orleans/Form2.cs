using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new_orleans
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mod = new Form3();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mod = new Form4();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mod = new Form7();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form mod = new Form24();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form mod = new Form16();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form mod = new Form27();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }
    }
}
