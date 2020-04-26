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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 1;
            if (this.radioButton2.Checked == true) suma++;
            if (this.radioButton7.Checked == true) suma++;
            if (this.radioButton10.Checked == true) suma++;
            if (this.radioButton13.Checked == true) suma++;
            if (this.radioButton4.Checked == true) suma++;
            if (this.radioButton1.Checked == true) suma++;
            if (this.radioButton5.Checked == true) suma++;
            if (this.radioButton11.Checked == true) suma++;
            if (this.radioButton14.Checked == true) suma++;
            if (suma <= 5) MessageBox.Show(suma.ToString() + " Mai incearca");
            else if (suma >= 6 && suma <= 8) MessageBox.Show(suma.ToString() + " Esti Bun");
            else if (suma >= 9) MessageBox.Show(suma.ToString() + " Felicitari");
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            Form1.ActiveForm.Close();
        }
    }
}
