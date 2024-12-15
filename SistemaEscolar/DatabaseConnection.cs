using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    class DatabaseConnection
    {
        SqlConnection sqlConn;

        public DatabaseConnection()
        {
            sqlConn = new SqlConnection("Data Source=ej-Desktop;Initial Catalog=SistemaBiblioteca;Integrated Security=True;Encrypt=False");
        }

        public SqlConnection Connect()
        {
            try
            {
                sqlConn.Open();
            } catch
            {
            }

            return sqlConn;
        }

        public void Disconnect()
        {
            try
            {
                sqlConn.Close();
            } catch
            {
            }
        }

        public bool Login(string user, string pass)
        {
            string query = $"SELECT ID, Usuario, Clave FROM dbo.Usuarios WHERE Usuario = '{user}' AND Clave = '{pass}'";

            SqlCommand command = new SqlCommand(query, Connect());
            SqlDataReader reader = command.ExecuteReader();

            bool existe = reader.HasRows;

            Disconnect();

            return existe;
        }
    }
}
