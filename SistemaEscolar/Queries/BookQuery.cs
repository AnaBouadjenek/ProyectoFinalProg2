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
    public partial class BookQueryForm : Form
    {
        Datos datos = new Datos();

        public BookQueryForm()
        {
            InitializeComponent();
        }

        private void BookQueryForm_Load(object sender, EventArgs e)
        {
            Buscarlibro.Focus();
            DataGridView.DataSource = datos.Consultar("Libros", "*", "");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string texto = BuscarTextBox.Text;
            DataGridView.DataSource = datos.Consultar(
                "Libros", 
                "*", 
                $"Codigo = {texto} OR Autor = {texto} OR Titulo = {texto} OR Descripcion = {texto} OR Edicion = {texto}");
        }
    }
}
