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
using SistemaEscolar.Queries;
using SistemaEscolar.Maintenance;

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

        private void UsuariosMenuItem_Click(object sender, EventArgs e)
        {
            UserQueryForm userQueryForm = new UserQueryForm();
            userQueryForm.ShowDialog();
        }

        private void CrearUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }

        private void ActualizarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm();
            updateUserForm.ShowDialog();
        }

        private void BookQueryMenuItem_Click(object sender, EventArgs e)
        {
            BookQueryForm consultaDeLibros = new BookQueryForm();
            consultaDeLibros.ShowDialog();
        }

        private void CreateBookMenuItem_Click(object sender, EventArgs e)
        {
            CreateBookForm createBookForm = new CreateBookForm();
            createBookForm.ShowDialog();
        }
    }
}
