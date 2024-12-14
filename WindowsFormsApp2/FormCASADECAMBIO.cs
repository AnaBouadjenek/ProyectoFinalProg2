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
    public partial class FormCASADECAMBIO : Form
    {
        public FormCASADECAMBIO()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Double RD, Euros, Resultado;
            Euros = 65.5;
            RD = double.Parse(textBox1.Text);
            Resultado = RD * Euros;
            label3.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = Resultado.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Visible = false;
            label3.Visible = false;
            textBox1.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Double rd, us, resul;
            us = 42.50;
            rd = Double.Parse(textBox1.Text);
            resul = rd * us;
            label3.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = resul.ToString();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Double RD, US, Resultado;
            US = 60.10;
            RD=Double.Parse(textBox1.Text);
            Resultado = RD / US;
            label3 .Visible = true;
            textBox2.Visible = true;
            textBox2.Text=Resultado.ToString();

        }
    }
}
