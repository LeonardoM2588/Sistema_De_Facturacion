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
    public partial class Frm_Empleados : Form
    {
        //Clases A Utilizar
        Helpers H = new Helpers();
        DataBase D = new DataBase();
        System_Data SE = new System_Data();
        EmpleadosController EC = new EmpleadosController();
        EmpleadosModel EM;
        DataUser U = new DataUser();

        //Variables Universales
        int errors = 0;

        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
            StarForm();
            Registros();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cancelar La Operacion?") == "S")
            {
                StarForm();
                ClearForm();
            }
        }

        //Metodo De Guardado    
        private void Guardar()
        {
            if (errors == 0)
            {
                Validando();
                Seteo();
                string procedimiento, values, indicador;
                procedimiento = "[sp_Empleados]";
                indicador = "1";
                values = "'" + EM.Cod_Empleado + "','" + EM.IdentidadEmpleado + "','" + EM.Nombre_Empleado + "','" + EM.Cod_Cargo + "','" + EM.Estado + "','" + EM.UsuarioCreacion + "',NULL";
                if (SE.Save(procedimiento, indicador, values) > 0)
                {
                    H.MsgSuccess("Se Guardo El Registro De Forma Satisfactoria!");
                    StarForm();
                    ClearForm();
                }
            }
        }

        public void GetCmb()
        {
            //Get Cargo
            Cmb_CargoEmpleado.DataSource = D.Find("Cargo", "*", "", "Cargo");
            Cmb_CargoEmpleado.ValueMember = "Cod_Cargo";
            Cmb_CargoEmpleado.DisplayMember = "Cargo";
            Cmb_CargoEmpleado.SelectedIndex = -1;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cerrar Esta Ventana?") == "S")
            {
                Frm_Panel Panel = new Frm_Panel();
                this.Hide();
                Panel.ShowDialog();
            }
        }

        public void Seteo()
        {
            //Estado,Propietario_Vivienda
            EM = new EmpleadosModel();
            EM.Cod_Empleado = int.Parse(Lbl_CodEmpleado.Text);
            EM.IdentidadEmpleado = Txt_IdentidadEmpleado.Text;
            EM.Nombre_Empleado = Txt_NombreEmpleado.Text;
            EM.FechaCreacion = DateTime.Today;
            EM.UsuarioCreacion = DataUser.USERNAME;
            EM.FechaModificacion = DateTime.Today;
            EM.UsuarioModificacion = DataUser.USERNAME;


            //Almacenado De Datos De Los ComboBox
            DataTable Busqueda = new DataTable();

            //ComboBox Cargos
            Busqueda = D.Find("Cargo", "*", "Cargo='" + Cmb_CargoEmpleado.Text + "'");

            if (Busqueda.Rows.Count > 0)
            {
                DataRow DATOS = Busqueda.Rows[0];
                if (Cmb_CargoEmpleado.Text == (DATOS["Cargo"].ToString()))
                {
                    EM.Cod_Cargo = int.Parse((DATOS["Cod_Cargo"].ToString()));
                }
            }

            //Almacenado De Datos De Los CheckBox
            //CheckBox Estado
            if (Check_Estado.Checked == true)
            {
                EM.Estado = true;
            }
            else
            {
                EM.Estado = false;
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cancelar La Busqueda?") == "S")
            {
                Txt_Buscar.Text = "";
                Txt_Buscar.Select();
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Generar Un Reporte?") == "S")
            {
                ExportarExcel();
            }
        }

        public Boolean Validando()
        {
            Boolean Valida = true;

            if (string.IsNullOrEmpty(Txt_NombreEmpleado.Text))
            {
                MessageBox.Show("El campo Nombre Del Empleado no puede quedar vacio");
                Txt_NombreEmpleado.Focus();
                Valida = false;
            }
            else
            {
                if (string.IsNullOrEmpty(Txt_IdentidadEmpleado.Text))
                {
                    MessageBox.Show("El campo Identidad Empleado no puede quedar vacio");
                    Txt_IdentidadEmpleado.Focus();
                    Valida = false;
                }
            }
            return Valida;
        }

        private void StarForm()
        {
            Txt_Buscar.Select();
            Registros();

            Txt_IdentidadEmpleado.Enabled = false;
            Txt_NombreEmpleado.Enabled = false;
            Cmb_CargoEmpleado.Enabled = false;

            Check_Estado.Enabled = false;

            //Botones Principales

            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Nuevo.Enabled = true;
            Btn_Editar.Enabled = false;

        }

        private void Nuevo()
        {
            ClearForm();
            string Busqueda;
            string columns, table;
            columns = "Cod_Empleado";
            table = "Empleados";
            Busqueda = D.GetNextID(columns, table, "");
            Lbl_CodEmpleado.Text = Busqueda.ToString();

            GetCmb();
            Txt_IdentidadEmpleado.Enabled = true;
            Txt_NombreEmpleado.Enabled = true;
            Cmb_CargoEmpleado.Enabled = true;

            Check_Estado.Enabled = true;

            Check_Estado.Checked = true;
            Check_Estado.Enabled = true;

            //Botones Principales

            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Eliminar.Enabled = false;
            Btn_Nuevo.Enabled = false;
            Btn_Editar.Enabled = false;
        }

        private void ClearForm()
        {

            Txt_Buscar.Select();

            Txt_IdentidadEmpleado.Clear();
            Txt_NombreEmpleado.Clear();

            GetCmb();
            Check_Estado.Enabled = false;
            Check_Estado.Checked = false;
        }

        public void Registros()
        {
            string procedimiento, Estado, indicador, values;
            procedimiento = "[sp_Empleados]";
            indicador = "6";
            Estado = "true";
            values = "'','','','','" + Estado + "',''";
            EC.ListarEmpleados(procedimiento, indicador, values, Estado);
            Dgv_Registros.DataSource = EmpleadosModel.ListarEmpleados;
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


            for (int i = 1; i < Dgv_Registros.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i] = Dgv_Registros.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i <= Dgv_Registros.RowCount - 1; i++)
            {
                for (int j = 0; j <= Dgv_Registros.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = Dgv_Registros[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = Dgv_Registros.Rows[i].Cells[j].Value.ToString();
                }
            }

            xlWorkBook.SaveAs("Reporte_Empleados.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Guardado en documentos");
        }

        public new void Update()
        {
            if (H.MsgQuestion("¿Desea Actualizar Este Producto?") == "S")
            {
                Seteo();
                string procedimiento, indicador, values;
                procedimiento = "[sp_Empleados]";
                indicador = "2";
                values = "'" + EM.Cod_Empleado + "','" + EM.IdentidadEmpleado + "','" + EM.Nombre_Empleado + "','" + EM.Cod_Cargo + "','" + EM.Estado + "','" + EM.UsuarioCreacion + "','" + EM.UsuarioModificacion + "'";
                SE.ActualizarDatos(procedimiento, indicador, values);
                Dgv_Registros.DataSource = EmpleadosModel.ListarEmpleados;
                H.MsgSuccess("Registro Actualizado Con Exito!");
                ClearForm();
                StarForm();
                Registros();
            }
            else
            {
                StarForm();
                ClearForm();
            }

        }

        public void Delete()
        {
            Seteo();
            if (D.Update("Empleados", "Estado='false'", "Cod_Empleado='" + EM.Cod_Empleado + "'") > 0)
            {
                H.MsgSuccess("Registro Eliminado Con Exito!");
                ClearForm();
                StarForm();
                Registros();
            }
        }

        private void Busqueda()
        {
            if (rbn_Nombre.Checked == true)
            {
                EmpleadosModel.ListarEmpleados.DefaultView.RowFilter = $"Nombre_Empleado like '%{Txt_Buscar.Text}%'";
            }
            else if (rbn_Identidad.Checked == true)
            {
                EmpleadosModel.ListarEmpleados.DefaultView.RowFilter = $"IdentidadEmpleado like '%{Txt_Buscar.Text}%'";
            }

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Eliminar Este Registro?") == "S")
            {
                Delete();
            }
        }

        private void Dgv_Registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Cod_Cargo;
            string Estado;

            if (Dgv_Registros.SelectedRows.Count > 0)
            {
                Nuevo();
                Btn_Nuevo.Enabled = false;
                Lbl_CodEmpleado.Text = Dgv_Registros.CurrentRow.Cells["Cod_Empleado"].Value.ToString();
                Txt_IdentidadEmpleado.Text = Dgv_Registros.CurrentRow.Cells["IdentidadEmpleado"].Value.ToString();
                Txt_NombreEmpleado.Text = Dgv_Registros.CurrentRow.Cells["Nombre_Empleado"].Value.ToString();
                Cod_Cargo = Dgv_Registros.CurrentRow.Cells["Cargo"].Value.ToString();
                Estado = Dgv_Registros.CurrentRow.Cells["Estado"].Value.ToString();


                Btn_Editar.Enabled = true;
                Btn_Eliminar.Enabled = true;
                Btn_Guardar.Enabled = false;

                //ComboBox 

                //Estado
                if (Estado == "True")
                {
                    Check_Estado.Checked = true;
                    Check_Estado.Enabled = false;
                }
                else if (Estado == "False")
                {
                    Check_Estado.Checked = false;
                    Check_Estado.Enabled = false;
                    Btn_Guardar.Enabled = false;
                    Btn_Eliminar.Enabled = false;
                }
                //Datos De ComboBox
                DataTable ID = new DataTable();

                //ComboBox Cargos
                ID = D.Find("Cargo", "*", "Cargo='" + Cod_Cargo + "'");

                if (ID.Rows.Count > 0)
                {
                    DataRow info = ID.Rows[0];
                    Cmb_CargoEmpleado.Text = info["Cargo"].ToString();
                }

                ID.Dispose();

                Lbl_CodEmpleado.Enabled = false;
            }
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            lbluserlogin.Text = Control_System.DataUser.REALNAMEUSER + " | ";
            lblfecha.Text = DateTime.Now.ToLongDateString().ToUpper() + " | ";
            lblusermanager.Text = Control_System.DataUser.ROLE;
            Registros();
            StarForm();
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Frm_Empleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Btn_Nuevo.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                Btn_Guardar.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                Btn_Editar.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                Btn_Eliminar.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                Btn_Cancelar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Btn_Close.PerformClick();
            }
        }

        private void Txt_IdentidadEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }

        private void Txt_Buscar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Txt_Buscar.Text == "")
            {
                Registros();
                StarForm();
            }
        }
    }
}
