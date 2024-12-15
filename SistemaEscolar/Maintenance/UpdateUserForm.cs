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
    public partial class UpdateUserForm : Form
    {
        Datos datos = new Datos();

        public UpdateUserForm()
        {
            InitializeComponent();
            IdTextBox.Focus();
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
            UserTextBox.Enabled = false;
            PassTextBox.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            datos.Actualizar(
                "Usuarios", 
                $"ID='{IdTextBox.Text}', Usuario='{UserTextBox.Text}', Clave='{PassTextBox.Text}'", 
                $"ID = {IdTextBox.Text}");
            Limpiar();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void BuscarButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string id = IdTextBox.Text;
            if (id == "")
            {
                return;
            }

            DataTable data = datos.Consultar("Usuarios", "*", $"ID = {id}");
            
            if (data.Rows.Count > 0)
            {
                UserTextBox.Text = data.Rows[0]["Usuario"].ToString();
                PassTextBox.Text = data.Rows[0]["Clave"].ToString();

                UserTextBox.Enabled = true;
                PassTextBox.Enabled = true;
            }
        }
    }
}
