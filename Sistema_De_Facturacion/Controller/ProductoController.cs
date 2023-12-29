using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Sistema_De_Facturacion.Model;

namespace Sistema_De_Facturacion.Controller
{
    class ProductoController
    {
        //Propiedades de la clase System
        string query;

        //Controller Listar Estado Civil
        public void ListarProductos(string Procedimiento, string indicador, string values)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Control_System.Conexion_Forma1().GetConexion())
                {
                    Con.Open();
                    query = "Execute dbo." + Procedimiento + " " + indicador + "," + values + "";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.CommandTimeout = 300;
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);

                        LeerDatos.Fill(dt);
                    }
                    Con.Close();
                }

                ProductoModel.ListarProducto = dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
