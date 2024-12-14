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
    public partial class CasaDeCambioForm : Form
    {
        public CasaDeCambioForm()
        {
            InitializeComponent();
        }

        private void UsdToDopLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double usd = 60.3;
            double dop = double.Parse(PrimerValorTextBox.Text);

            ResultadoTextBox.Text = (usd * dop).ToString();
        }

        private void EurToDopLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double eur = 72.4;
            double dop = double.Parse(PrimerValorTextBox.Text);

            ResultadoTextBox.Text = (eur * dop).ToString();
        }

        private void DopToUsdLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double usd = 60.3;
            double dop = double.Parse(PrimerValorTextBox.Text);

            ResultadoTextBox.Text = (dop / usd).ToString();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ResultadoTextBox.Clear();
            PrimerValorTextBox.Clear();
            PrimerValorTextBox.Focus();
        }
    }
}
