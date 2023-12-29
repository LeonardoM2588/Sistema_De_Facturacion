using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_De_Facturacion.Login
{
    public partial class Frm_ChangePassword : Form
    {

        Control_System.Helpers H = new Control_System.Helpers();
        Control_System.DataBase D = new Control_System.DataBase();
        Control_System.DataUser U = new Control_System.DataUser();

        int errors;
        string name, password, confirmate;

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_user.Focus();
            }
        }

        private void txt_confirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_password.Focus();
            }
        }

        private new void Validate()
        {

            if (txt_user.Text.Trim().Length == 0)
            {
                H.MsgWarning("Ingresar un usuario!");
                txt_user.Focus();
                errors++;
                return;
            }
            if (txt_password.Text.Trim().Length == 0)
            {
                H.MsgWarning("Ingrese Una Contraseña Valida!");
                txt_password.Focus();
                errors++;
                return;
            }
            if (txt_confirmar.Text.Trim().Length == 0)
            {
                H.MsgWarning("Ingrese La Confirmacion De La Contraseña!");
                txt_confirmar.Focus();
                errors++;
                return;
            }
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            Validate();
            Enter();
        }

        public Frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            txt_user.Select();
        }
        private new void Enter()
        {

            name = H.SanitizeStr(txt_user.Text);
            password = U.MakeHash(txt_password.Text);
            confirmate = H.SanitizeStr(txt_confirmar.Text);

            DataTable Busqueda = new DataTable();
            Busqueda = D.Find("Usuarios", "*", "Usuario='" + name + "'");

            if (Busqueda.Rows.Count > 0)
            {
                DataRow DATOS = Busqueda.Rows[0];
                if (name == DATOS["Usuario"].ToString() && password.Trim().Length > 0 && confirmate.Trim().Length > 0)
                {
                    string data = "Contrasena ='" + password + "'";
                    string condition = "Usuario='" + name + "'";
                    if (D.Update("Usuarios", data, condition) > 0)
                    {
                        H.MsgSuccess("Contraseña Actualizada. Pase Feliz Tarde :)!");
                        Close();
                    }
                }
            }
            else
            {
                H.MsgWarning("Nombre De Usuario Inexistente!");
            }

        }
    }
}
