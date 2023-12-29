
namespace Sistema_De_Facturacion.View
{
    partial class Frm_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblcodusuario = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbn_Usuario = new System.Windows.Forms.RadioButton();
            this.rbn_nombre = new System.Windows.Forms.RadioButton();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.Btn_CancelarBusqueda = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_Identidad = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_NivelAcceso = new System.Windows.Forms.ComboBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Cod_Empleado = new System.Windows.Forms.TextBox();
            this.Check_Estado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stprincipal = new System.Windows.Forms.StatusStrip();
            this.lbluserlogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusermanager = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.sprlibros = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.sprmiembros = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.sprprestamos = new System.Windows.Forms.ToolStripSeparator();
            this.BTNELIMINAR = new System.Windows.Forms.ToolStripButton();
            this.sprreportes = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Regresar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stprincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 31);
            this.panel1.TabIndex = 267;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(641, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Usuarios";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblcodusuario);
            this.groupBox5.Location = new System.Drawing.Point(13, 547);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(1278, 57);
            this.groupBox5.TabIndex = 277;
            this.groupBox5.TabStop = false;
            // 
            // lblcodusuario
            // 
            this.lblcodusuario.AutoSize = true;
            this.lblcodusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblcodusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblcodusuario.ForeColor = System.Drawing.Color.Transparent;
            this.lblcodusuario.Location = new System.Drawing.Point(9, 15);
            this.lblcodusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodusuario.Name = "lblcodusuario";
            this.lblcodusuario.Size = new System.Drawing.Size(14, 18);
            this.lblcodusuario.TabIndex = 8;
            this.lblcodusuario.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_registros);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(335, 152);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(961, 391);
            this.groupBox3.TabIndex = 276;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // dgv_registros
            // 
            this.dgv_registros.AllowUserToAddRows = false;
            this.dgv_registros.AllowUserToDeleteRows = false;
            this.dgv_registros.AllowUserToResizeColumns = false;
            this.dgv_registros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_registros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_registros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_registros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_registros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(5, 30);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.RowHeadersWidth = 51;
            this.dgv_registros.Size = new System.Drawing.Size(951, 356);
            this.dgv_registros.TabIndex = 272;
            this.dgv_registros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbn_Usuario);
            this.groupBox2.Controls.Add(this.rbn_nombre);
            this.groupBox2.Controls.Add(this.Btn_Imprimir);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.Btn_CancelarBusqueda);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(335, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(961, 76);
            this.groupBox2.TabIndex = 275;
            this.groupBox2.TabStop = false;
            // 
            // rbn_Usuario
            // 
            this.rbn_Usuario.AutoSize = true;
            this.rbn_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbn_Usuario.Location = new System.Drawing.Point(101, 20);
            this.rbn_Usuario.Name = "rbn_Usuario";
            this.rbn_Usuario.Size = new System.Drawing.Size(85, 22);
            this.rbn_Usuario.TabIndex = 274;
            this.rbn_Usuario.Text = "Usuario";
            this.rbn_Usuario.UseVisualStyleBackColor = true;
            // 
            // rbn_nombre
            // 
            this.rbn_nombre.AutoSize = true;
            this.rbn_nombre.Checked = true;
            this.rbn_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbn_nombre.Location = new System.Drawing.Point(9, 20);
            this.rbn_nombre.Name = "rbn_nombre";
            this.rbn_nombre.Size = new System.Drawing.Size(86, 22);
            this.rbn_nombre.TabIndex = 273;
            this.rbn_nombre.TabStop = true;
            this.rbn_nombre.Text = "Nombre";
            this.rbn_nombre.UseVisualStyleBackColor = true;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Location = new System.Drawing.Point(912, 43);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(44, 23);
            this.Btn_Imprimir.TabIndex = 272;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(812, 43);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(44, 23);
            this.Btn_Buscar.TabIndex = 256;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_buscar.Location = new System.Drawing.Point(68, 44);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(738, 24);
            this.txt_buscar.TabIndex = 254;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // Btn_CancelarBusqueda
            // 
            this.Btn_CancelarBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarBusqueda.Image")));
            this.Btn_CancelarBusqueda.Location = new System.Drawing.Point(862, 43);
            this.Btn_CancelarBusqueda.Name = "Btn_CancelarBusqueda";
            this.Btn_CancelarBusqueda.Size = new System.Drawing.Size(44, 23);
            this.Btn_CancelarBusqueda.TabIndex = 255;
            this.Btn_CancelarBusqueda.UseVisualStyleBackColor = true;
            this.Btn_CancelarBusqueda.Click += new System.EventHandler(this.Btn_CancelarBusqueda_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(6, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 18);
            this.label20.TabIndex = 253;
            this.label20.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(301, 471);
            this.groupBox1.TabIndex = 273;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Txt_Identidad);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Cmb_NivelAcceso);
            this.groupBox4.Controls.Add(this.Txt_Contraseña);
            this.groupBox4.Controls.Add(this.Txt_Usuario);
            this.groupBox4.Controls.Add(this.Txt_Cod_Empleado);
            this.groupBox4.Controls.Add(this.Check_Estado);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(4, 162);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(293, 305);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // Txt_Identidad
            // 
            this.Txt_Identidad.Location = new System.Drawing.Point(84, 84);
            this.Txt_Identidad.Mask = "0000-0000-00000";
            this.Txt_Identidad.Name = "Txt_Identidad";
            this.Txt_Identidad.Size = new System.Drawing.Size(201, 24);
            this.Txt_Identidad.TabIndex = 275;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 273;
            this.label1.Text = "Identidad";
            // 
            // Cmb_NivelAcceso
            // 
            this.Cmb_NivelAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_NivelAcceso.FormattingEnabled = true;
            this.Cmb_NivelAcceso.Location = new System.Drawing.Point(149, 217);
            this.Cmb_NivelAcceso.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_NivelAcceso.Name = "Cmb_NivelAcceso";
            this.Cmb_NivelAcceso.Size = new System.Drawing.Size(137, 26);
            this.Cmb_NivelAcceso.TabIndex = 272;
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(110, 171);
            this.Txt_Contraseña.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(175, 24);
            this.Txt_Contraseña.TabIndex = 17;
            this.Txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(84, 124);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(201, 24);
            this.Txt_Usuario.TabIndex = 16;
            // 
            // Txt_Cod_Empleado
            // 
            this.Txt_Cod_Empleado.Location = new System.Drawing.Point(190, 40);
            this.Txt_Cod_Empleado.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cod_Empleado.Name = "Txt_Cod_Empleado";
            this.Txt_Cod_Empleado.Size = new System.Drawing.Size(96, 24);
            this.Txt_Cod_Empleado.TabIndex = 15;
            this.Txt_Cod_Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cod_Empleado_KeyPress);
            // 
            // Check_Estado
            // 
            this.Check_Estado.AutoSize = true;
            this.Check_Estado.Location = new System.Drawing.Point(102, 276);
            this.Check_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.Check_Estado.Name = "Check_Estado";
            this.Check_Estado.Size = new System.Drawing.Size(73, 22);
            this.Check_Estado.TabIndex = 13;
            this.Check_Estado.Text = "Activo";
            this.Check_Estado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nivel De Acceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo De  Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // stprincipal
            // 
            this.stprincipal.AutoSize = false;
            this.stprincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stprincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbluserlogin,
            this.lblfecha,
            this.lblusermanager});
            this.stprincipal.Location = new System.Drawing.Point(0, 606);
            this.stprincipal.Name = "stprincipal";
            this.stprincipal.Size = new System.Drawing.Size(1307, 26);
            this.stprincipal.TabIndex = 345;
            this.stprincipal.Text = "statusStrip1";
            // 
            // lbluserlogin
            // 
            this.lbluserlogin.BackColor = System.Drawing.Color.Transparent;
            this.lbluserlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserlogin.Image = ((System.Drawing.Image)(resources.GetObject("lbluserlogin.Image")));
            this.lbluserlogin.Name = "lbluserlogin";
            this.lbluserlogin.Size = new System.Drawing.Size(20, 21);
            // 
            // lblfecha
            // 
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Image = ((System.Drawing.Image)(resources.GetObject("lblfecha.Image")));
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(20, 21);
            // 
            // lblusermanager
            // 
            this.lblusermanager.BackColor = System.Drawing.Color.Transparent;
            this.lblusermanager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusermanager.Image = ((System.Drawing.Image)(resources.GetObject("lblusermanager.Image")));
            this.lblusermanager.Name = "lblusermanager";
            this.lblusermanager.Size = new System.Drawing.Size(20, 21);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Nuevo,
            this.sprlibros,
            this.Btn_Guardar,
            this.sprmiembros,
            this.Btn_Editar,
            this.sprprestamos,
            this.BTNELIMINAR,
            this.sprreportes,
            this.Btn_Regresar,
            this.Btn_Cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1307, 34);
            this.toolStrip1.TabIndex = 346;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.AutoSize = false;
            this.Btn_Nuevo.BackColor = System.Drawing.Color.GhostWhite;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(95, 31);
            this.Btn_Nuevo.Text = "NUEVO F3";
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // sprlibros
            // 
            this.sprlibros.Name = "sprlibros";
            this.sprlibros.Size = new System.Drawing.Size(6, 34);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.GhostWhite;
            this.Btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(110, 31);
            this.Btn_Guardar.Text = "GUARDAR F4";
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // sprmiembros
            // 
            this.sprmiembros.Name = "sprmiembros";
            this.sprmiembros.Size = new System.Drawing.Size(6, 34);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.GhostWhite;
            this.Btn_Editar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.Image")));
            this.Btn_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(92, 31);
            this.Btn_Editar.Text = "EDITAR F5";
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // sprprestamos
            // 
            this.sprprestamos.Name = "sprprestamos";
            this.sprprestamos.Size = new System.Drawing.Size(6, 34);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.GhostWhite;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNELIMINAR.Image")));
            this.BTNELIMINAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTNELIMINAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(107, 31);
            this.BTNELIMINAR.Text = "ELIMINAR F6";
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // sprreportes
            // 
            this.sprreportes.Name = "sprreportes";
            this.sprreportes.Size = new System.Drawing.Size(6, 34);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Btn_Regresar.BackColor = System.Drawing.Color.GhostWhite;
            this.Btn_Regresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(67, 31);
            this.Btn_Regresar.Text = "SALIR";
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click_1);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(115, 31);
            this.Btn_Cancelar.Text = "CANCELAR F7";
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 632);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stprincipal);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Usuarios_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stprincipal.ResumeLayout(false);
            this.stprincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbn_Usuario;
        private System.Windows.Forms.RadioButton rbn_nombre;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button Btn_CancelarBusqueda;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox Cmb_NivelAcceso;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Cod_Empleado;
        private System.Windows.Forms.CheckBox Check_Estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcodusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip stprincipal;
        private System.Windows.Forms.ToolStripStatusLabel lbluserlogin;
        private System.Windows.Forms.ToolStripStatusLabel lblfecha;
        private System.Windows.Forms.ToolStripStatusLabel lblusermanager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Txt_Identidad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Nuevo;
        private System.Windows.Forms.ToolStripSeparator sprlibros;
        private System.Windows.Forms.ToolStripButton Btn_Guardar;
        private System.Windows.Forms.ToolStripSeparator sprmiembros;
        private System.Windows.Forms.ToolStripButton Btn_Editar;
        private System.Windows.Forms.ToolStripSeparator sprprestamos;
        private System.Windows.Forms.ToolStripButton BTNELIMINAR;
        private System.Windows.Forms.ToolStripSeparator sprreportes;
        private System.Windows.Forms.ToolStripButton Btn_Regresar;
        private System.Windows.Forms.ToolStripButton Btn_Cancelar;
    }
}