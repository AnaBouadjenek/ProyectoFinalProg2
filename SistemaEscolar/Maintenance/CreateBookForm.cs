﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEscolar.Maintenance
{
    public partial class CreateBookForm : Form
    {
        Datos datos = new Datos();

        public CreateBookForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CodigoTextBox.Clear();
            AutorTextBox.Clear();
            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            EdicionTextBox.Clear();

            CodigoTextBox.Focus();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            datos.Insertar(
                "Libros",
                "Codigo, Autor, Titulo, Descripcion, Edicion", 
                $"'{CodigoTextBox.Text}', '{AutorTextBox.Text}', '{TituloTextBox.Text}', '{DescripcionTextBox.Text}', '{EdicionTextBox.Text}'");

            Limpiar();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
