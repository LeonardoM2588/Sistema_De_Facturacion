using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_De_Facturacion.Model;
using Sistema_De_Facturacion.Controller;
using Sistema_De_Facturacion.Control_System;
using Sistema_De_Facturacion.Clases_System;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Sistema_De_Facturacion.View
{
    public partial class Frm_RegistrosFactura : Form
    {
        //Clases A Utilizar
        Helpers H = new Helpers();
        DataBase D = new DataBase();
        System_Data SE = new System_Data();
        DataUser U = new DataUser();
        clsFactura CF = new clsFactura();

        ProductoController PC = new ProductoController();
        FacturaController FC = new FacturaController();
        public Frm_RegistrosFactura()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_RegistrosFactura_Load(object sender, EventArgs e)
        {
            StarForm();
            DatosFactura();
        }

        private void DatosFactura()
        {
            string procedimiento, indicador, values;

            procedimiento = "[sp_factura]";
            indicador = "4";
            values = "'','','','','','','','','',''";
            FC.ListarFactura(procedimiento, indicador, values);
            dgv_registros.DataSource = FacturaModel.ListarFactura;
        }

        public void Busqueda()
        {
            if (MSKFECHA.MaskCompleted)
            {
                msk_busquedaprimaria.Enabled = false;
                string procedimiento, indicador, values;

                procedimiento = "[sp_factura]";
                indicador = "7";
                values = "'','','" + MSKFECHA.Text + "','','','','','','',''";
                FC.ListarFactura(procedimiento, indicador, values);
                dgv_registros.DataSource = FacturaModel.ListarFactura;
            }
            else if(msk_busquedaprimaria.MaskCompleted)
            {
                MSKFECHA.Enabled = false;
                string procedimiento, indicador, values;

                procedimiento = "[sp_factura]";
                indicador = "5";
                values = "'" + msk_busquedaprimaria.Text + "','','','','','','','','',''";
                FC.ListarFactura(procedimiento, indicador, values);
                dgv_registros.DataSource = FacturaModel.ListarFactura;
            }
            else
            {
                DatosFactura();
            }
           
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Btn_Buscar.Enabled = false;
            Busqueda();
        }

        private void Btn_CancelarBusqueda_Click(object sender, EventArgs e)
        {
            msk_busquedaprimaria.Clear();
            MSKFECHA.Clear();
            MSKFECHA.Enabled = true;
            msk_busquedaprimaria.Enabled = true;
            Btn_Buscar.Enabled = true;
            DatosFactura();
        }

        public void Delete()
        {
            if (D.Update("Factura", "Estado='false'", "IdFactura='" + lblidfactura.Text + "'") > 0)
            {
                H.MsgSuccess("Registro Eliminado Con Exito!");
                StarForm();
                DatosFactura();
            }
        }

        private void StarForm() {

            lbluserlogin.Text = DataUser.REALNAMEUSER + " | ";
            lblfecha.Text = DateTime.Now.ToLongDateString().ToUpper() + " | ";
            lblusermanager.Text = DataUser.ROLE;


            BTNELIMINAR.Enabled = false;
            BTNELIMINAR.Visible = false;
        }

        private void dgv_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_registros.SelectedRows.Count > 0)
            {
                BTNELIMINAR.Enabled = true;
                BTNELIMINAR.Visible = true;
                lblidfactura.Text = dgv_registros.CurrentRow.Cells["IdFactura"].Value.ToString();
            }
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void msk_busquedaprimaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
