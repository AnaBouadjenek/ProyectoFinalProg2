using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class LoginForm : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
     
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string user = UserTextBox.Text;
            string pass = PasswordTextBox.Text;

            if (conn.Login(user, pass))
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                
                Close();
            } else
            {
                MessageBox.Show("Usuario incorrecto");
                UserTextBox.Focus();
                PasswordTextBox.Clear();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}