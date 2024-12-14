using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Tools;

namespace SistemaEscolar
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SalirMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LaSumadoraMenuItem_Click(object sender, EventArgs e)
        {
            LaSumadoraForm laSumadoraForm = new LaSumadoraForm();
            laSumadoraForm.ShowDialog();
        }

        private void CasaDeCambioMenuItem_Click(object sender, EventArgs e)
        {
            CasaDeCambioForm casaDeCambioForm = new CasaDeCambioForm();
            casaDeCambioForm.ShowDialog();
        }

        private void NominaSemanalMenuItem_Click(object sender, EventArgs e)
        {
            NominaSemanalForm nominaSemanalForm = new NominaSemanalForm();
            nominaSemanalForm.ShowDialog();
        }
    }
}
