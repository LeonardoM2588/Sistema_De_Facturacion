using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Sistema_De_Facturacion.Control_System
{
    class Conexion_Forma1
    {
        public SqlConnection GetConexion()
        {
            string NombreConexion = "Sistema_De_Facturacion.Properties.Settings.Valor";

            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings[NombreConexion].ToString());

            return sqlCon;
        }

        public SqlConnection GetConexion(string Servidor)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings[Servidor].ToString());

            return sqlCon;
        }
    }
}
