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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mod = new Form28();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int suma = 1;
            if (this.radioButton2.Checked == true) suma++;
            if (this.radioButton7.Checked == true) suma++;
            if (this.radioButton10.Checked == true) suma++;
            if (this.radioButton13.Checked == true) suma++;
            if (this.radioButton4.Checked == true) suma++;
            if (this.radioButton21.Checked == true) suma++;
            if (this.radioButton25.Checked == true) suma++;
            if (this.radioButton31.Checked == true) suma++;
            if (this.radioButton36.Checked == true) suma++;
            if (suma <= 5) MessageBox.Show(suma.ToString() + " Mai incearca");
            else if (suma >= 6 && suma <= 8) MessageBox.Show(suma.ToString() + " Esti Bun");
            else if (suma >= 9) MessageBox.Show(suma.ToString() + " Felicitari");
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            Form1.ActiveForm.Close();
        }
    }
}
