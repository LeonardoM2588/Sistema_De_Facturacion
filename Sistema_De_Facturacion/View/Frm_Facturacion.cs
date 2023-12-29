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
    public partial class Frm_Facturacion : Form
    {
        //Clases A Utilizar
        Helpers H = new Helpers();
        DataBase D = new DataBase();
        System_Data SE = new System_Data();
        DataUser U = new DataUser();
        clsFactura CF = new clsFactura();

        ProductoController PC = new ProductoController();
        FacturaController FC = new FacturaController();
        FacturaModel FM;
        Conversion c = new Conversion();

        //Variables Universales
        int errors = 0;
        string valorletras;
        double impuesto;
        double total;
        public Frm_Facturacion()
        {
            InitializeComponent();
        }

        private void CmbProductos() {

            //Get Producto
            cmbProducto.DataSource = D.Find("Producto", "*", "Estado = '1'", "Producto");
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.DisplayMember = "Producto";
            cmbProducto.SelectedIndex = -1;
        }
        private void Registros() {
            
            CmbProductos();

            string procedimiento, indicador, values;
           
            procedimiento = "[sp_Producto]";
            indicador = "6";
            values = "'','','',''";
            PC.ListarProductos(procedimiento, indicador, values);
            dgvproductos.DataSource = ProductoModel.ListarProducto;

        }

        private void DatosProductos() {
            string procedimiento, indicador, values;

            procedimiento = "[sp_Producto]";
            indicador = "6";
            values = "'','','',''";
            PC.ListarProductos(procedimiento, indicador, values);
            dgvproductos.DataSource = ProductoModel.ListarProducto;
        }

        private void StarForm() {

            lbluserlogin.Text = DataUser.REALNAMEUSER + " | ";
            lblfecha.Text = DateTime.Now.ToLongDateString().ToUpper() + " | ";
            lblusermanager.Text = DataUser.ROLE;

            txt_buscar.Select();
            btnEliminar.Enabled = false;


            ClearForm();
            string Busqueda;
            string columns, table;
            columns = "IdFactura";
            table = "Factura";
            Busqueda = D.GetNextID(columns, table, "");
            lblidfactura.Text = Busqueda.ToString();
            lblidfactura.Visible = false;
        }


        private void Frm_Facturacion_Load_1(object sender, EventArgs e)
        {
            StarForm();
            Registros();
            DatosProductos();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "")
            {
                lblCodigo.Text = "-";
                lblPrecio.Text = "-";
                lblNombre.Text = "-";
            }
            else
            {
                //Almacenado De Datos De Los ComboBox
                DataTable Busqueda = new DataTable();

                //ComboBox Paquetes
                Busqueda = D.Find("Producto", "*", "Producto='" + cmbProducto.Text + "'");

                if (Busqueda.Rows.Count > 0)
                {
                    DataRow DATOS = Busqueda.Rows[0];
                    if (cmbProducto.Text == (DATOS["Producto"].ToString()))
                    {
                        lblCodigo.Text = DATOS["IdProducto"].ToString();
                        lblPrecio.Text = DATOS["Precio"].ToString();
                        lblNombre.Text = DATOS["Producto"].ToString();
                    }
                }
            }
           
        }


        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = dgvLista.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
                impuesto = costot * 0.15;
                total = impuesto + costot;
            }

            lblTotatlPagar.Text = total.ToString();
            lblcostosinimpuesto.Text = costot.ToString();
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);

            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = lblPrecio.Text;
            if (txtCantidad.Text == "")
            {
                H.MsgWarning("NO PUEDES DEJAR LA CANTIDAD EN BLANCO! SE AGREGARA EN AUTOMATICO EL VALOR DE '1'");
                txtCantidad.Text = "1";
            }
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();


            dgvLista.Rows.Add(file);

            lblCodigo.Text = lblNombre.Text = lblPrecio.Text = txtCantidad.Text = "";

            obtenerTotal();
            UpdateTotal();
        }

        private void UpdateTotal() {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotatlPagar.Text)).ToString();


            }
            catch { }

            if (txtEfectivo.Text == "")
            {
                lblDevolucion.Text = "";
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch { }

            obtenerTotal();
            UpdateTotal();

            if (lblcostosinimpuesto.Text == "0")
            {
                lblTotatlPagar.Text = "0";
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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


            for (int i = 1; i < dgvproductos.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i] = dgvproductos.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i <= dgvproductos.RowCount - 1; i++)
            {
                for (int j = 0; j <= dgvproductos.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvproductos[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = dgvproductos.Rows[i].Cells[j].Value.ToString();
                }
            }

            xlWorkBook.SaveAs("Reporte_Productos.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Guardado en documentos");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cerrar Esta Ventana?") == "S")
            {
                Frm_Panel Panel = new Frm_Panel();
                this.Hide();
                Panel.ShowDialog();
            }
        }

        private void Busqueda()
        {
            ProductoModel.ListarProducto.DefaultView.RowFilter = $"Producto like '%{txt_buscar.Text}%'";
        }

        private void Facturacion() {

            //validacion de datos en letras
            valorletras = c.enletras(lblTotatlPagar.Text).ToLower();

            //datos de la factura
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("COMEDOR LA CASA DE LA FRITURA"); //imprime una linea de descripcion TUTULO DE LA FACTURA
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: " + lblidfactura.Text);
            Ticket1.TextoIzquierda("RNT EMPRESA: 17091974005380");
            Ticket1.TextoIzquierda("CAI: 7773DA7-AAADA1-3F449B-C68508-1D0860-A3");
            Ticket1.TextoIzquierda("     -1D0860-A3");
            if (txt_rtncliente.Text == "")
            {
                Ticket1.TextoIzquierda("RTN Cliente: " + "SIN RTN");
            }
            else
            {
                Ticket1.TextoIzquierda("RTN Cliente: " + txt_rtncliente.Text);
            }
            Ticket1.TextoIzquierda("DIRECCION: BARRIO EL CENTRO CONTINUO");
            Ticket1.TextoIzquierda("           A SPORTNIKE");
            Ticket1.TextoIzquierda("TELEFONO: 3158-5366");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: "+ Control_System.DataUser.REALNAMEUSER);
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Valor Impuesto: " , double.Parse(impuesto.ToString()));
            Ticket1.AgregaTotales("Total: ", double.Parse(lblTotatlPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoIzquierda("Valor En Letras: " + valorletras);
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "ZDesigner ZQ320 (CPCL)"; //NOMBRE DE LA IMPRESORA
            Ticket1.ImprimirTiket(impresora);


        }

        private void Comanda()
        {

            //validacion de datos en letras
            valorletras = c.enletras(lblTotatlPagar.Text).ToLower();

            //datos de la factura
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("COMEDOR LA CASA DE LA FRITURA"); //imprime una linea de descripcion TUTULO DE LA FACTURA
            Ticket1.TextoCentro(" ");

            Ticket1.TextoCentro("COMANDA DE VENTA");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoIzquierda("No Fac: " + lblidfactura.Text);

            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: " + Control_System.DataUser.REALNAMEUSER);
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Valor Impuesto: ", double.Parse(impuesto.ToString()));
            Ticket1.AgregaTotales("Total: ", double.Parse(lblTotatlPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 
            Ticket1.TextoIzquierda(" ");
            string impresora = "ZDesigner ZQ320 (CPCL)"; //NOMBRE DE LA IMPRESORA
            Ticket1.ImprimirTiket(impresora);


        }
        public void Seteo()
        {
            FM = new FacturaModel();
            FM.IdFactura = int.Parse(lblidfactura.Text);
            FM.Rtn_Cliente = txt_rtncliente.Text;
            FM.Fecha_Factura = DateTime.Now;
            FM.Cantidad_Total = (lblTotatlPagar.Text);
            FM.Impuesto_Total = impuesto.ToString();
            FM.Efectivo = txtEfectivo.Text;
            FM.Devuelto = lblDevolucion.Text;
            FM.Estado = true;
            FM.FechaCreacion = DateTime.Now;
            FM.UsuarioCreacion = DataUser.USERNAME;
            FM.FechaModificacion = DateTime.Now;
            FM.UsuarioModificacion = DataUser.USERNAME;

        }

        public Boolean Validando()
        {
            Boolean Valida = true;

            if (string.IsNullOrEmpty(txtEfectivo.Text))
            {
                MessageBox.Show("EL CAMPO EFECTIVO NO PUEDE QUEDAR VACIO!");
                txtEfectivo.Focus();
                Valida = false;
            }
            return Valida;
        }

        private void ClearForm() {
            txtCantidad.Clear();
            txtEfectivo.Clear();
            txt_buscar.Clear();
            lblPrecio.Text = "-";
            cmbProducto.SelectedIndex = -1;
            lblDevolucion.Text = "-";
            lblTotatlPagar.Text = "-";
            txt_rtncliente.Clear();
            dgvLista.Rows.Clear();
            lblcostosinimpuesto.Text = "-";
        }

        private void Guardar() {

            if (errors == 0)
            {
                Validando();
                Seteo();
                string procedimiento, values, indicador;
                procedimiento = "[sp_factura]";
                indicador = "1";
                values = "'" + FM.IdFactura + "','" + FM.Rtn_Cliente + "','" + FM.Fecha_Factura + "','" + FM.Cantidad_Total + "','" + FM.Impuesto_Total + "','" + FM.Efectivo + "','" + FM.Devuelto + "','" + FM.Estado + "','" + FM.UsuarioCreacion+"','"+FM.FechaCreacion+"'";
                if (SE.Save(procedimiento, indicador, values) > 0)
                {
                    timer1.Start();
                    H.MsgSuccess("Se Guardo El Registro De Forma Satisfactoria!");

                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿DESEA GENERAR UNA FACTURA?") == "S")
            {
                Facturacion();
                Guardar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Comanda();
            StarForm();
            ClearForm();
            timer1.Stop();
        }

        private void Btn_Imprimir_Click_1(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Generar Un Reporte?") == "S")
            {
                ExportarExcel();
            }
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            View.Frm_RegistrosFactura Admin = new Frm_RegistrosFactura();
            Admin.ShowDialog();
        }

        private void txt_rtncliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Busqueda();
            Btn_Buscar.Enabled = false;
        }

        private void Btn_CancelarBusqueda_Click_1(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cancelar La Busqueda?") == "S")
            {
                txt_buscar.Text = "";
                txt_buscar.Select();
                DatosProductos();
            }
        }
    }
}
