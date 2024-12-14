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
    public partial class LaSumadoraForm : Form
    {
        public LaSumadoraForm()
        {
            InitializeComponent();
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Double.Parse(PrimerValorTextBox.Text);
                double valor2 = Double.Parse(SegundoValorTextBox.Text);

                ResultadoTextBox.Text = (valor1 + valor2).ToString();
            } catch (Exception)
            {
                MessageBox.Show("Algo salio mal.");
            }
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Double.Parse(PrimerValorTextBox.Text);
                double valor2 = Double.Parse(SegundoValorTextBox.Text);

                ResultadoTextBox.Text = (valor1 - valor2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal.");
            }

        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Double.Parse(PrimerValorTextBox.Text);
                double valor2 = Double.Parse(SegundoValorTextBox.Text);

                ResultadoTextBox.Text = (valor1 * valor2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal.");
            }
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Double.Parse(PrimerValorTextBox.Text);
                double valor2 = Double.Parse(SegundoValorTextBox.Text);

                if (valor2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                }
                else
                {
                    ResultadoTextBox.Text = (valor1 / valor2).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal.");
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
