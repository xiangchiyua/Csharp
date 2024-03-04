using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_2
{
    public partial class Form1 : Form
    {
        float a, b;char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = float.Parse(Input1.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            b = float.Parse(Input2.Text);
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = '+';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op = '-';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = '/';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+': Output.Text = (a + b).ToString(); break;
                case '-': Output.Text = (a - b).ToString(); break;
                case '*': Output.Text = (a * b).ToString(); break;
                case '/': Output.Text = (a / b).ToString(); break;
            }
        }
    }
}
