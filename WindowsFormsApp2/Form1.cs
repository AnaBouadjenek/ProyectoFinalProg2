using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=int.Parse(textBox1.Text);
            b=int.Parse(textBox2.Text);
            c = a + b;
            textBox3.Text=c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b=int.Parse(textBox2.Text);
            c = a - b;
            textBox3.Text=c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
                b=int.Parse(textBox2.Text);
            c = a * b;
            textBox3.Text=c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if (b == 0)
            {
                label5.Visible = true;

            }
            else
            {
                label5.Visible = false;
                c = a / b;
                textBox3.Text = c.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
