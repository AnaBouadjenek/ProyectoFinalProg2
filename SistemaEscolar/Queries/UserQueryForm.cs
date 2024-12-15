using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Queries
{
    public partial class UserQueryForm : Form
    {
        Datos datos = new Datos();

        public UserQueryForm()
        {
            InitializeComponent();
        }

        public void UserQueryForm_Load(object sender, EventArgs e)
        {
            BuscarTextBox.Focus();
            DataGridView.DataSource = datos.Consultar("Usuarios", "ID, Usuario", "");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string texto = BuscarTextBox.Text;
            DataGridView.DataSource = datos.Consultar("Usuarios", "ID, Usuario", $"ID = '{texto}' OR Usuario = '{texto}'");
        }
    }
}
