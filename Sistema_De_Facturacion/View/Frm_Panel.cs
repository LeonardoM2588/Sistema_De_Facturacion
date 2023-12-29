using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_De_Facturacion.Control_System;

namespace Sistema_De_Facturacion.View
{
    public partial class Frm_Panel : Form
    {
        Helpers H = new Helpers();
        DataBase D = new DataBase();
        DataUser U = new DataUser();

        public Frm_Panel()
        {
            InitializeComponent();
        }

        private void Frm_Panel_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            lbluserlogin.Text = DataUser.REALNAMEUSER + " | ";
            lblfecha.Text = DateTime.Now.ToLongDateString().ToUpper() + " | ";
            lblusermanager.Text = DataUser.ROLE;
            lbluser.Text = DataUser.USERNAME;
            lblNombre.Text = DataUser.REALNAMEUSER;
            lblidentidad.Text = DataUser.IDENTIDADEMPLEADO;

            switch (DataUser.ROLE)
            {
                case "Administrador":
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = false;
                    break;

                case "Sistemas":
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    break;

                case "Gerente":
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = false;
                    break;

                case "Caja Principal":
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    break;

            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (H.MsgQuestion("¿Desea Cerrar La Sesion Actual?") == "S")
            {
                Login.Frm_Login Login = new Login.Frm_Login();
                this.Hide();
                Login.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View.Frm_Usuarios Admin = new Frm_Usuarios();
            DataUser.Contador = 4;
            this.Hide();
            Admin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.Frm_Facturacion Admin = new Frm_Facturacion();
            DataUser.Contador = 1;
            this.Hide();
            Admin.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.Frm_Productos Admin = new Frm_Productos();
            DataUser.Contador = 2;
            this.Hide();
            Admin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View.Frm_Empleados Admin = new Frm_Empleados();
            DataUser.Contador = 3;
            this.Hide();
            Admin.ShowDialog();
        }
    }
}
