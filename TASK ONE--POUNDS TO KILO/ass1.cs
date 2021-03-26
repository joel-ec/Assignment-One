using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Pound = (double)numericUpDown1.Value;
            double Answer = Pound * 0.453592;
            label3.Text = Answer.ToString() + "KGs";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double kilo = (double)numericUpDown2.Value;
            double Answer2 = kilo * 2.20462;
            label3.Text = Answer2.ToString()  +"Pounds";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label3.Text = "Answer:";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
