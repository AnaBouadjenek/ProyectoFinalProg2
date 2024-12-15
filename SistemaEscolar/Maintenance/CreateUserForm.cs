using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Maintenance
{
    public partial class CreateUserForm : Form
    {
        Datos datos = new Datos();

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            UserTextBox.Clear();
            PassTextBox.Clear();

            UserTextBox.Focus();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            datos.Insertar("Usuarios", "ID, Usuario, Clave", $"'{IdTextBox.Text}', '{UserTextBox.Text}', '{PassTextBox.Text}'");
            Limpiar();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
