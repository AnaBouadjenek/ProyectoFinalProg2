using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    internal class Datos
    {
        DatabaseConnection connection = new DatabaseConnection();
        DataSet dataSet = new DataSet();
        SqlDataAdapter dataAdapter;

        public DataTable Consultar(string tabla, string campos, string condicion)
        {
            string query = "SELECT " + campos + " FROM " + tabla;
            if (condicion != "")
            {
                query += " WHERE " + condicion;
            }

            try
            {
                dataAdapter = new SqlDataAdapter(query, connection.Connect());
                dataAdapter.Fill(dataSet, "TDATOS");
                connection.Disconnect();
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


            return dataSet.Tables["TDATOS"];
        }

        public void Insertar(string tabla, string campos, string valores)
        {
            string query = "INSERT INTO " + tabla + "(" + campos + ") VALUES (" + valores + ")";
          
            try
            {
                SqlCommand command = new SqlCommand(query, connection.Connect());
                command.ExecuteNonQuery();
                connection.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Actualizar(string tabla, string campos, string condicion)
        {
            string query = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion + "";

            try
            {
                SqlCommand command = new SqlCommand(query, connection.Connect());
                command.ExecuteNonQuery();
                connection.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
