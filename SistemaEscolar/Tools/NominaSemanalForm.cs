using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Tools
{
    public partial class NominaSemanalForm : Form
    {
        public NominaSemanalForm()
        {
            InitializeComponent();
        }

        private void Formnominasemanal_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Lunes = 0, Martes = 0, Miercoles = 0, Jueves = 0, Viernes = 0, Sabado = 0, Domingo = 0, HN = 0, HE = 0, CA = 0, Salario;
            int.TryParse(textBox1.Text, out Lunes);
            int.TryParse(textBox2.Text, out Martes);
            int.TryParse(textBox3.Text, out Miercoles);
            int.TryParse(textBox4.Text, out Jueves);
            int.TryParse(textBox5.Text, out Viernes);
            int.TryParse(textBox6.Text, out Sabado);
            int.TryParse(textBox7.Text, out Domingo);
            CA = Lunes + Martes + Miercoles + Jueves + Viernes + Sabado + Domingo;
            if (CA > 40)
            {
                HN = 40 * 220;
                HE = (CA - 40) * 300;

            }
            else
            {
                HE = 0;
                HN = CA * 220;

            }
            Salario = HN + HE;
            textBox8.Text = Salario.ToString();

        }
    }
}
