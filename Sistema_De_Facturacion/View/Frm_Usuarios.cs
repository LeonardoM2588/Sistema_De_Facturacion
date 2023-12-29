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
    public partial class Frm_Usuarios : Form
    {
        //Clases A Utilizar
        Helpers H = new Helpers();
        DataBase D = new DataBase();
        System_Data SE = new System_Data();
        UsuariosController UC = new UsuariosController();
        UsuariosModel UM;
        DataUser U = new DataUser();

        //Variables Universales
        int errors = 0;

        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            StarForm();
        }

        private void Guardar()
        {
            if (errors == 0)
            {
                Validando();
                Seteo();
                string procedimiento, values, indicador;
                procedimiento = "[sp_EventosUsuario]";
                indicador = "1";
                values = "'" + UM.Cod_Usuario + "','" + UM.Cod_Empleado + "','" + UM.IdentidadEmpleado + "','" + UM.Usuario + "','" + UM.Contrasena + "','" + UM.IdNivelUser + "','" + UM.Estado + "'";
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
            //Get nivel user
            Cmb_NivelAcceso.DataSource = D.Find("Nivel_Acceso", "*", "", "Nivel_Acceso");
            Cmb_NivelAcceso.ValueMember = "IdNivelUser";
            Cmb_NivelAcceso.DisplayMember = "Nivel_Acceso";
            Cmb_NivelAcceso.SelectedIndex = -1;
        }

        public void Seteo()
        {

            UM = new UsuariosModel();
            UM.Cod_Usuario = int.Parse(lblcodusuario.Text);
            UM.Cod_Empleado = int.Parse(Txt_Cod_Empleado.Text);
            UM.IdentidadEmpleado = Txt_Identidad.Text;
            UM.Usuario = Txt_Usuario.Text;
            UM.Contrasena = U.MakeHash(Txt_Contraseña.Text);

            //datos del cmb
            DataTable Busqueda = new DataTable();
            Busqueda = D.Find("Nivel_Acceso", "*", "Nivel_Acceso='" + Cmb_NivelAcceso.Text + "'");

            if (Busqueda.Rows.Count > 0)
            {
                DataRow DATOS = Busqueda.Rows[0];
                if (Cmb_NivelAcceso.Text == (DATOS["Nivel_Acceso"].ToString()))
                {
                    UM.IdNivelUser = int.Parse((DATOS["IdNivelUser"].ToString()));
                }
            }

            //datos del checkbox
            if (Check_Estado.Checked == true)
            {
                UM.Estado = true;
            }
            else
            {
                UM.Estado = false;
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                Registros();
                StarForm();
            }
        }

        private void Btn_CancelarBusqueda_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cancelar La Busqueda?") == "S")
            {
                txt_buscar.Text = "";
                txt_buscar.Select();
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea exportar a Excel", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                ExportarExcel();
            }
            else
            {
                return;
            }
        }

        public Boolean Validando()
        {
            Boolean Valida = true;

            if (string.IsNullOrEmpty(Txt_Cod_Empleado.Text))
            {
                MessageBox.Show("El campo codigo de empleado no puede quedar vacio");
                Txt_Cod_Empleado.Focus();
                Valida = false;
            }
            else
            {
                if (string.IsNullOrEmpty(Txt_Identidad.Text))
                {
                    MessageBox.Show("El campo identidad de empleado no puede quedar vacio");
                    Txt_Identidad.Focus();
                    Valida = false;
                }

                if (string.IsNullOrEmpty(Txt_Usuario.Text))
                {
                    MessageBox.Show("El campo usuario no puede quedar vacio");
                    Txt_Usuario.Focus();
                    Valida = false;
                }

                if (string.IsNullOrEmpty(Txt_Contraseña.Text))
                {
                    MessageBox.Show("El campo contraseña no puede quedar vacio");
                    Txt_Contraseña.Focus();
                    Valida = false;
                }
            }
            return Valida;
        }

        private void StarForm()
        {
            txt_buscar.Select();
            Registros();
            Txt_Cod_Empleado.Enabled = false;
            Txt_Contraseña.Enabled = false;
            Txt_Identidad.Enabled = false;
            Txt_Usuario.Enabled = false;

            Txt_Identidad.Enabled = false;

            lbluserlogin.Text = DataUser.REALNAMEUSER + " | ";
            lblfecha.Text = DateTime.Now.ToLongDateString().ToUpper() + " | ";
            lblusermanager.Text = DataUser.ROLE;

            Check_Estado.Enabled = false;

            //Botones Principales
            Btn_Regresar.Enabled = true;

            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            BTNELIMINAR.Enabled = false;
            Btn_Nuevo.Enabled = true;
            Btn_Editar.Enabled = false;
            dgv_registros.DefaultCellStyle.ForeColor = Color.Black;
            Cmb_NivelAcceso.Enabled = false;
        }
        private void Nuevo()
        {
            ClearForm();
            string Busqueda;
            string columns, table;
            columns = "Cod_Usuario";
            table = "Usuarios";
            Busqueda = D.GetNextID(columns, table, "");
            lblcodusuario.Text = Busqueda.ToString();

            GetCmb();
            Txt_Cod_Empleado.Enabled = true;
            Txt_Contraseña.Enabled = true;
            Txt_Identidad.Enabled = true;
            Txt_Usuario.Enabled = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                    ctrl.Text = "";
                }
            }
            Txt_Identidad.Enabled = true;
            Txt_Contraseña.Enabled = true;
            Check_Estado.Checked = true;
            Check_Estado.Enabled = true;
            Cmb_NivelAcceso.Enabled = true;

            //Botones Principales
            Btn_Regresar.Enabled = false;

            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = true;
        }

        private void ClearForm()
        {

            txt_buscar.Select();
            Txt_Cod_Empleado.Clear();
            Txt_Usuario.Clear();
            lblcodusuario.Text="-";
            Txt_Contraseña.Clear();
            Cmb_NivelAcceso.Text = "";
            Txt_Identidad.ResetText();

            GetCmb();
            Check_Estado.Enabled = false;
            Check_Estado.Checked = false;
        }
        public void Registros()
        {
            string procedimiento, Estado, indicador, values;
            procedimiento = "[sp_EventosUsuario]";
            indicador = "6";
            Estado = "true";
            values = "'','','','','" + Estado + "',''";
            UC.ListarUsuarios_Activos(procedimiento, indicador, values, Estado);
            dgv_registros.DataSource = UsuariosModel.ListarUsuarios;
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

            xlWorkBook.SaveAs("Reporte_Usuarios.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Guardado en documentos");
        }

        public void Eliminar()
        {
            if (H.MsgQuestion("¿Desea Eliminar Este Registro?") == "S")
            {
                Seteo();
                string procedimiento, indicador, values;
                procedimiento = "[sp_EventosUsuario]";
                indicador = "2";
                values = "'" + UM.Cod_Usuario + "','" + UM.Cod_Empleado + "','" + UM.IdentidadEmpleado + "','" + UM.Usuario + "','" + UM.Contrasena + "','" + UM.IdNivelUser + "','0'";
                SE.ActualizarDatos(procedimiento, indicador, values);
                dgv_registros.DataSource = UsuariosModel.ListarUsuarios;
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

        public new void Update()
        {
            if (H.MsgQuestion("¿Desea Actualizar Este Registro?") == "S")
            {
                Seteo();
                string procedimiento, indicador, values;
                procedimiento = "[sp_EventosUsuario]";
                indicador = "2";
                values = "'" + UM.Cod_Usuario + "','" + UM.Cod_Empleado + "','" + UM.IdentidadEmpleado + "','" + UM.Usuario + "','" + UM.Contrasena + "','" + UM.IdNivelUser + "','"+UM.Estado+"'";
                SE.ActualizarDatos(procedimiento, indicador, values);
                dgv_registros.DataSource = UsuariosModel.ListarUsuarios;
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

        private void Busqueda()
        {

            if (rbn_nombre.Checked == true)
            {
                UsuariosModel.ListarUsuarios.DefaultView.RowFilter = $"Nombre_Empleado like '%{txt_buscar.Text}%'";
            }
            else if (rbn_Usuario.Checked == true)
            {
                UsuariosModel.ListarUsuarios.DefaultView.RowFilter = $"Usuario like '%{txt_buscar.Text}%'";
            }
        }

        private void dgv_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Estado, Empleado, IdNivelUser;

            if (dgv_registros.SelectedRows.Count > 0)
            {
                Nuevo();
                Btn_Nuevo.Enabled = false;
                lblcodusuario.Text = dgv_registros.CurrentRow.Cells["Cod_Usuario"].Value.ToString();
                Txt_Usuario.Text = dgv_registros.CurrentRow.Cells["Usuario"].Value.ToString();
                Txt_Contraseña.Text = dgv_registros.CurrentRow.Cells["Contrasena"].Value.ToString();
                Txt_Identidad.Text = dgv_registros.CurrentRow.Cells["IdentidadEmpleado"].Value.ToString();
                Txt_Contraseña.Enabled = false;

                Empleado = dgv_registros.CurrentRow.Cells["Nombre_Empleado"].Value.ToString();
                IdNivelUser = dgv_registros.CurrentRow.Cells["Nivel_Acceso"].Value.ToString();


                Btn_Editar.Enabled = true;
                Btn_Guardar.Enabled = false;
                BTNELIMINAR.Enabled = true;

                Estado = dgv_registros.CurrentRow.Cells["Estado"].Value.ToString();
                if (Estado == "True")
                {
                    Check_Estado.Checked = true;
                }
                else if (Estado == "False")
                {
                    Check_Estado.Checked = false;
                    Check_Estado.Enabled = false;
                    Btn_Guardar.Enabled = false;
                }

                DataTable ID = new DataTable();
                ID = D.Find("Empleados", "*", "Nombre_Empleado='" + Empleado + "'");

                if (ID.Rows.Count > 0)
                {
                    DataRow info = ID.Rows[0];
                    Txt_Cod_Empleado.Text = info["Cod_Empleado"].ToString();
                }

                ID = D.Find("Nivel_Acceso", "*", "Nivel_Acceso='" + IdNivelUser + "'");

                if (ID.Rows.Count > 0)
                {
                    DataRow info = ID.Rows[0];
                    Cmb_NivelAcceso.Text = info["Nivel_Acceso"].ToString();
                }

                ID.Dispose();
            }
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

        private void Btn_Regresar_Click_1(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cerrar Esta Ventana?") == "S")
            {
                Frm_Panel Panel = new Frm_Panel();
                this.Hide();
                Panel.ShowDialog();
            }
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Frm_Usuarios_KeyDown(object sender, KeyEventArgs e)
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
                BTNELIMINAR.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                Btn_Cancelar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Btn_Regresar.PerformClick();
            }
        }

        private void Txt_Cod_Empleado_KeyPress(object sender, KeyPressEventArgs e)
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
