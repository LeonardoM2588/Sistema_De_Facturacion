
namespace Sistema_De_Facturacion.View
{
    partial class Frm_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.Btn_Maximizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.sprlibros = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.sprmiembros = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.sprprestamos = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.sprreportes = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbn_Identidad = new System.Windows.Forms.RadioButton();
            this.rbn_Nombre = new System.Windows.Forms.RadioButton();
            this.Cmb_CargoEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.Txt_IdentidadEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Check_Estado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stprincipal = new System.Windows.Forms.StatusStrip();
            this.lbluserlogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusermanager = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dgv_Registros = new System.Windows.Forms.DataGridView();
            this.Lbl_CodEmpleado = new System.Windows.Forms.Label();
            this.Txt_Buscar = new System.Windows.Forms.MaskedTextBox();
            this.panelBarraTitulo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Registros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelBarraTitulo.Controls.Add(this.Btn_Maximizar);
            this.panelBarraTitulo.Controls.Add(this.label3);
            this.panelBarraTitulo.Controls.Add(this.Btn_Minimizar);
            this.panelBarraTitulo.Controls.Add(this.Btn_Close);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1307, 32);
            this.panelBarraTitulo.TabIndex = 34;
            // 
            // Btn_Maximizar
            // 
            this.Btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximizar.AutoSize = true;
            this.Btn_Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Maximizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Maximizar.Image")));
            this.Btn_Maximizar.Location = new System.Drawing.Point(1245, 3);
            this.Btn_Maximizar.Name = "Btn_Maximizar";
            this.Btn_Maximizar.Size = new System.Drawing.Size(24, 24);
            this.Btn_Maximizar.TabIndex = 49;
            this.Btn_Maximizar.UseVisualStyleBackColor = false;
            this.Btn_Maximizar.Click += new System.EventHandler(this.Btn_Maximizar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(503, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Menu De Empleados";
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.AutoSize = true;
            this.Btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(1215, 3);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(24, 24);
            this.Btn_Minimizar.TabIndex = 47;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.AutoSize = true;
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.Location = new System.Drawing.Point(1275, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(24, 24);
            this.Btn_Close.TabIndex = 46;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
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
            this.Btn_Eliminar,
            this.sprreportes,
            this.Btn_Cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1307, 34);
            this.toolStrip1.TabIndex = 60;
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
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.GhostWhite;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(107, 31);
            this.Btn_Eliminar.Text = "ELIMINAR F6";
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // sprreportes
            // 
            this.sprreportes.Name = "sprreportes";
            this.sprreportes.Size = new System.Drawing.Size(6, 34);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Buscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbn_Identidad);
            this.groupBox2.Controls.Add(this.rbn_Nombre);
            this.groupBox2.Controls.Add(this.Cmb_CargoEmpleado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Txt_NombreEmpleado);
            this.groupBox2.Controls.Add(this.Txt_IdentidadEmpleado);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.Btn_Imprimir);
            this.groupBox2.Controls.Add(this.Btn_Cancel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Check_Estado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1307, 194);
            this.groupBox2.TabIndex = 349;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 24);
            this.label5.TabIndex = 361;
            this.label5.Text = "  DATOS GENERALES DEL EMPLEADO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbn_Identidad
            // 
            this.rbn_Identidad.AutoSize = true;
            this.rbn_Identidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_Identidad.Location = new System.Drawing.Point(846, 114);
            this.rbn_Identidad.Name = "rbn_Identidad";
            this.rbn_Identidad.Size = new System.Drawing.Size(83, 20);
            this.rbn_Identidad.TabIndex = 354;
            this.rbn_Identidad.Text = "Identidad";
            this.rbn_Identidad.UseVisualStyleBackColor = true;
            // 
            // rbn_Nombre
            // 
            this.rbn_Nombre.AutoSize = true;
            this.rbn_Nombre.Checked = true;
            this.rbn_Nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_Nombre.Location = new System.Drawing.Point(761, 113);
            this.rbn_Nombre.Name = "rbn_Nombre";
            this.rbn_Nombre.Size = new System.Drawing.Size(74, 20);
            this.rbn_Nombre.TabIndex = 353;
            this.rbn_Nombre.TabStop = true;
            this.rbn_Nombre.Text = "Nombre";
            this.rbn_Nombre.UseVisualStyleBackColor = true;
            // 
            // Cmb_CargoEmpleado
            // 
            this.Cmb_CargoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CargoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Cmb_CargoEmpleado.FormattingEnabled = true;
            this.Cmb_CargoEmpleado.Location = new System.Drawing.Point(252, 139);
            this.Cmb_CargoEmpleado.Name = "Cmb_CargoEmpleado";
            this.Cmb_CargoEmpleado.Size = new System.Drawing.Size(264, 27);
            this.Cmb_CargoEmpleado.TabIndex = 360;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 23);
            this.label4.TabIndex = 359;
            this.label4.Text = "Cargo Del Empleado:";
            // 
            // Txt_NombreEmpleado
            // 
            this.Txt_NombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NombreEmpleado.Location = new System.Drawing.Point(252, 100);
            this.Txt_NombreEmpleado.Name = "Txt_NombreEmpleado";
            this.Txt_NombreEmpleado.Size = new System.Drawing.Size(370, 27);
            this.Txt_NombreEmpleado.TabIndex = 358;
            // 
            // Txt_IdentidadEmpleado
            // 
            this.Txt_IdentidadEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_IdentidadEmpleado.Location = new System.Drawing.Point(252, 64);
            this.Txt_IdentidadEmpleado.Mask = "0000-0000-00000";
            this.Txt_IdentidadEmpleado.Name = "Txt_IdentidadEmpleado";
            this.Txt_IdentidadEmpleado.Size = new System.Drawing.Size(177, 27);
            this.Txt_IdentidadEmpleado.TabIndex = 357;
            this.Txt_IdentidadEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_IdentidadEmpleado_KeyPress);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(1150, 142);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(44, 23);
            this.Btn_Buscar.TabIndex = 354;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Location = new System.Drawing.Point(1250, 142);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(44, 23);
            this.Btn_Imprimir.TabIndex = 353;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.Image")));
            this.Btn_Cancel.Location = new System.Drawing.Point(1200, 142);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(44, 23);
            this.Btn_Cancel.TabIndex = 352;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 355;
            this.label7.Text = "BUSCAR:";
            // 
            // Check_Estado
            // 
            this.Check_Estado.AutoSize = true;
            this.Check_Estado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Check_Estado.Location = new System.Drawing.Point(533, 139);
            this.Check_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.Check_Estado.Name = "Check_Estado";
            this.Check_Estado.Size = new System.Drawing.Size(89, 27);
            this.Check_Estado.TabIndex = 349;
            this.Check_Estado.Text = "Activo";
            this.Check_Estado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 348;
            this.label2.Text = "Nombre Del Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 347;
            this.label1.Text = "Identidad De Empleado:";
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
            this.stprincipal.TabIndex = 350;
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
            // Dgv_Registros
            // 
            this.Dgv_Registros.AllowUserToAddRows = false;
            this.Dgv_Registros.AllowUserToDeleteRows = false;
            this.Dgv_Registros.AllowUserToResizeColumns = false;
            this.Dgv_Registros.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Registros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Registros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Registros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Registros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Registros.Location = new System.Drawing.Point(0, 266);
            this.Dgv_Registros.Name = "Dgv_Registros";
            this.Dgv_Registros.RowHeadersWidth = 51;
            this.Dgv_Registros.Size = new System.Drawing.Size(1307, 315);
            this.Dgv_Registros.TabIndex = 351;
            this.Dgv_Registros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Registros_CellDoubleClick);
            // 
            // Lbl_CodEmpleado
            // 
            this.Lbl_CodEmpleado.AutoSize = true;
            this.Lbl_CodEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_CodEmpleado.Location = new System.Drawing.Point(8, 584);
            this.Lbl_CodEmpleado.Name = "Lbl_CodEmpleado";
            this.Lbl_CodEmpleado.Size = new System.Drawing.Size(10, 13);
            this.Lbl_CodEmpleado.TabIndex = 352;
            this.Lbl_CodEmpleado.Text = "-";
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Buscar.Location = new System.Drawing.Point(761, 140);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(383, 27);
            this.Txt_Buscar.TabIndex = 362;
            this.Txt_Buscar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Buscar_MaskInputRejected);
            this.Txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Buscar_KeyPress);
            // 
            // Frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 632);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl_CodEmpleado);
            this.Controls.Add(this.Dgv_Registros);
            this.Controls.Add(this.stprincipal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBarraTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Empleados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Empleados_KeyDown);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stprincipal.ResumeLayout(false);
            this.stprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button Btn_Maximizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Nuevo;
        private System.Windows.Forms.ToolStripSeparator sprlibros;
        private System.Windows.Forms.ToolStripButton Btn_Guardar;
        private System.Windows.Forms.ToolStripSeparator sprmiembros;
        private System.Windows.Forms.ToolStripButton Btn_Editar;
        private System.Windows.Forms.ToolStripSeparator sprprestamos;
        private System.Windows.Forms.ToolStripButton Btn_Eliminar;
        private System.Windows.Forms.ToolStripSeparator sprreportes;
        private System.Windows.Forms.ToolStripButton Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Check_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip stprincipal;
        private System.Windows.Forms.ToolStripStatusLabel lbluserlogin;
        private System.Windows.Forms.ToolStripStatusLabel lblfecha;
        private System.Windows.Forms.ToolStripStatusLabel lblusermanager;
        private System.Windows.Forms.DataGridView Dgv_Registros;
        private System.Windows.Forms.TextBox Txt_NombreEmpleado;
        private System.Windows.Forms.MaskedTextBox Txt_IdentidadEmpleado;
        private System.Windows.Forms.Label Lbl_CodEmpleado;
        private System.Windows.Forms.ComboBox Cmb_CargoEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbn_Identidad;
        private System.Windows.Forms.RadioButton rbn_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Txt_Buscar;
    }
}