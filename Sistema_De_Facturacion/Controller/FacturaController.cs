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
    class FacturaController
    {
        //Propiedades de la clase System
        string query;

        //Controller Listar Estado Civil
        public void ListarFactura(string Procedimiento, string indicador, string values)
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

                FacturaModel.ListarFactura = dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Metodo Search with BETWEEN
        //Busca registros en la base de datos
        public void BETWEENFacturas(string Procedimiento, string indicador, string values, string condition1, string condition2)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Control_System.Conexion_Forma1().GetConexion())
                {
                    Con.Open();
                    query = "Execute dbo." + Procedimiento + " " + indicador + "," + values + ","+condition1+","+condition2+"";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.CommandTimeout = 300;
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);

                        LeerDatos.Fill(dt);
                    }
                    Con.Close();
                }

                FacturaModel.ListarFactura = dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
        //fin Metodo Save
    }
}
