using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value = ProgressBar.Value + 1;
            if (ProgressBar.Value == ProgressBar.Maximum)
            {
                Timer.Stop();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}
