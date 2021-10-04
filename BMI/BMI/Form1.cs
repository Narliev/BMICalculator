using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;
            calc.Visible = true;
            clear.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            show_button.Visible = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0 || textBox2.Text.Length == 0)
            {
                warning.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                warning.Visible = false;
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                label5.Text = ((num1 / (num2 * num2)) * 10000).ToString("N2");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
