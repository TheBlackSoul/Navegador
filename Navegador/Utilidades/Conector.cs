using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador.Utilidades
{    public class Conector

    {
        private MySqlConnection conexion;
        private string sConexion;
      
  
        public bool OpenConnection()
        {
            sConexion = "SERVER=" + "localhost" + ";" + "DATABASE=" +
            "blog" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";";
            conexion = new MySqlConnection(sConexion);
            try
            {
                conexion.Open();
                MessageBox.Show("Test Correct");
                return true;
            }
            catch (MySqlException ex)
            {
                  switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
