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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Sistema_De_Facturacion.View
{
    public partial class Frm_Productos : Form
    {

        //Clases A Utilizar
        Helpers H = new Helpers();
        DataBase D = new DataBase();
        System_Data SE = new System_Data();
        DataUser U = new DataUser();

        ProductoController PC = new ProductoController();
        ProductoModel PM = new ProductoModel();

        //Variables Universales
        int errors = 0;
        public Frm_Productos()
        {
            InitializeComponent();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cerrar Esta Ventana?") == "S")
            {
                View.Frm_Panel Admin = new View.Frm_Panel();
                this.Hide();
                Admin.ShowDialog();
            }
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            StarForm();
        }

        private void Registros()
        {
            string procedimiento, indicador, values;

            procedimiento = "[sp_Producto]";
            indicador = "4";
            values = "'','','','1'";
            PC.ListarProductos(procedimiento, indicador, values);
            dgv_registros.DataSource = ProductoModel.ListarProducto;

        }

        private void StarForm() {

            Registros();

            lbluserlogin.Text = DataUser.REALNAMEUSER + " | ";
            lblfecha.Text = DateTime.Now.ToLongDateString().ToUpper() + " | ";
            lblusermanager.Text = DataUser.ROLE;

            txt_buscar.Select();
            Btn_Eliminar.Enabled = false;
            BTNNUEVO.Enabled = true;
            BTNGUARDAR.Enabled = false;
            BTNEDITAR.Enabled = false;
            Btn_Eliminar.Enabled = false;
            BTNCANCELAR.Enabled = false;


            txt_producto.Enabled = false;
            txt_precio.Enabled = false;

            Check_Estado.Enabled = false;

            Btn_Buscar.Focus();

            ClearForm();
           
        }

        private void New() {

            string Busqueda;
            string columns, table;
            columns = "IdFactura";
            table = "Factura";
            Busqueda = D.GetNextID(columns, table, "");
            lblidproducto.Text = Busqueda.ToString();
            lblidproducto.Visible = false;


            Btn_Eliminar.Enabled = false;
            BTNNUEVO.Enabled = false;
            BTNGUARDAR.Enabled = true;
            BTNEDITAR.Enabled = false;
            Btn_Eliminar.Enabled = false;
            BTNCANCELAR.Enabled = true;


            txt_producto.Enabled = true;
            txt_producto.Focus();
            txt_precio.Enabled = true;

            Check_Estado.Enabled = true;
        }

        void ExportarExcel()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            for (int i = 1; i < dgv_registros.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i] = dgv_registros.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i <= dgv_registros.RowCount - 1; i++)
            {
                for (int j = 0; j <= dgv_registros.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_registros[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = dgv_registros.Rows[i].Cells[j].Value.ToString();
                }
            }

            xlWorkBook.SaveAs("Reporte_Productos.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Guardado en documentos");
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Generar Un Reporte?") == "S")
            {
                ExportarExcel();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cancelar La Busqueda?") == "S")
            {
                txt_buscar.Text = "";
                txt_buscar.Select();
                Registros();
            }
        }

        public void Seteo()
        {
            PM = new ProductoModel();
            PM.IdProducto = int.Parse(lblidproducto.Text);
            PM.Producto = txt_producto.Text;
            PM.Precio = txt_precio.Text;
            
            if (Check_Estado.Checked == true)
            {
                PM.Estado = true;
            }
            else if (Check_Estado.Checked == false)
            {
                PM.Estado = false;
            }
        }

        public Boolean Validando()
        {
            Boolean Valida = true;

            if (string.IsNullOrEmpty(txt_producto.Text))
            {
                MessageBox.Show("EL CAMPO PRODUCTO NO PUEDE QUEDAR VACIO!");
                txt_producto.Focus();
                Valida = false;
            }
            else if (string.IsNullOrEmpty(txt_precio.Text))
            {
                MessageBox.Show("EL CAMPO PRECIO NO PUEDE QUEDAR VACIO!");
                txt_precio.Focus();
                Valida = false;
            }
            return Valida;
        }

        private void ClearForm()
        {
            txt_producto.Clear();
            txt_precio.Clear();
            txt_buscar.Clear();
            lblidproducto.Text = "-";
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save() {

            if (errors == 0)
            {
                Validando();
                Seteo();
                string procedimiento, values, indicador;
                procedimiento = "[sp_Producto]";
                indicador = "1";
                values = "'" + PM.IdProducto + "','" + PM.Producto + "','" + PM.Precio + "','" + PM.Estado + "'";
                
                if (SE.Save(procedimiento, indicador, values) > 0)
                {
                    H.MsgSuccess("Se Guardo El Registro De Forma Satisfactoria!");
                    ClearForm();
                    StarForm();
                }
            }
        }

        private void dgv_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Estado;

            if (dgv_registros.SelectedRows.Count > 0)
            {
                New();
                BTNNUEVO.Enabled = false;
                lblidproducto.Text = dgv_registros.CurrentRow.Cells["IdProducto"].Value.ToString();
                txt_producto.Text = dgv_registros.CurrentRow.Cells["Producto"].Value.ToString();
                txt_precio.Text = dgv_registros.CurrentRow.Cells["Precio"].Value.ToString();

                BTNEDITAR.Enabled = true;
                BTNGUARDAR.Enabled = false;
                Btn_Eliminar.Enabled = true;

                Estado = dgv_registros.CurrentRow.Cells["Estado"].Value.ToString();
                if (Estado == "True")
                {
                    Check_Estado.Checked = true;
                }
                else if (Estado == "False")
                {
                    Check_Estado.Checked = false;
                    Check_Estado.Enabled = false;
                    BTNGUARDAR.Enabled = false;
                }
            }
        }

        private void delete()
        {
            if (H.MsgQuestion("¿DESEA ELIMINAR EL REGISTRO?") == "S")
            {
                if (D.Update("Producto", "Estado=0", "IdProducto='" + lblidproducto.Text.Trim() + "'") > 0)
                {
                    H.MsgSuccess("SE ELIMINO EL REGISTRO DE FORMA SATISFACTORIA!");
                    ClearForm();
                    StarForm();
                }
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            delete();
        }

        public new void Update()
        {
            if (H.MsgQuestion("¿Desea Actualizar Este Registro?") == "S")
            {
                Seteo();
                string procedimiento, indicador, values;
                procedimiento = "[sp_Producto]";
                indicador = "2";
                values = "'" + PM.IdProducto + "','" + PM.Producto + "','" + PM.Precio + "','" + PM.Estado + "'";
                SE.ActualizarDatos(procedimiento, indicador, values);
                dgv_registros.DataSource = UsuariosModel.ListarUsuarios;
                H.MsgSuccess("Registro Actualizado Con Exito!");
                ClearForm();
                StarForm();
            }
            else
            {
                StarForm();
                ClearForm();
            }

        }

        private void BTNEDITAR_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            New();
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            ClearForm();
            StarForm();
        }

        private void Frm_Productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                BTNNUEVO.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                BTNGUARDAR.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                BTNEDITAR.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                Btn_Eliminar.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                BTNCANCELAR.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_close.PerformClick();
            }
        }
    }
}
