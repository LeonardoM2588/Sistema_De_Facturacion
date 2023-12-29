
namespace Sistema_De_Facturacion.View
{
    partial class Frm_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.stprincipal = new System.Windows.Forms.StatusStrip();
            this.lbluserlogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusermanager = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.MaskedTextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.Check_Estado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNNUEVO = new System.Windows.Forms.ToolStripButton();
            this.sprlibros = new System.Windows.Forms.ToolStripSeparator();
            this.BTNGUARDAR = new System.Windows.Forms.ToolStripButton();
            this.sprmiembros = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEDITAR = new System.Windows.Forms.ToolStripButton();
            this.sprprestamos = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.sprreportes = new System.Windows.Forms.ToolStripSeparator();
            this.BTNCANCELAR = new System.Windows.Forms.ToolStripButton();
            this.panelBarraTitulo.SuspendLayout();
            this.stprincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelBarraTitulo.Controls.Add(this.button1);
            this.panelBarraTitulo.Controls.Add(this.label3);
            this.panelBarraTitulo.Controls.Add(this.btn_minimizar);
            this.panelBarraTitulo.Controls.Add(this.btn_close);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1307, 32);
            this.panelBarraTitulo.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1245, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(561, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Menu De Productos";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.AutoSize = true;
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1215, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(24, 24);
            this.btn_minimizar.TabIndex = 47;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AutoSize = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1275, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.TabIndex = 46;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.stprincipal.TabIndex = 34;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv_registros);
            this.groupBox1.Controls.Add(this.lblidproducto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1307, 574);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.Btn_Imprimir);
            this.groupBox2.Controls.Add(this.Btn_Cancel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.txt_producto);
            this.groupBox2.Controls.Add(this.Check_Estado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1301, 130);
            this.groupBox2.TabIndex = 348;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 24);
            this.label5.TabIndex = 362;
            this.label5.Text = "  DATOS GENERALES DEL PRODUCTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(1149, 93);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(44, 23);
            this.Btn_Buscar.TabIndex = 354;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.White;
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_buscar.Location = new System.Drawing.Point(607, 91);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(536, 27);
            this.txt_buscar.TabIndex = 356;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Location = new System.Drawing.Point(1249, 93);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(44, 23);
            this.Btn_Imprimir.TabIndex = 353;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.Image")));
            this.Btn_Cancel.Location = new System.Drawing.Point(1199, 93);
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
            this.label7.Location = new System.Drawing.Point(528, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 355;
            this.label7.Text = "BUSCAR:";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_precio.Location = new System.Drawing.Point(111, 89);
            this.txt_precio.Mask = "00";
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(52, 27);
            this.txt_precio.TabIndex = 351;
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(111, 52);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(310, 27);
            this.txt_producto.TabIndex = 350;
            // 
            // Check_Estado
            // 
            this.Check_Estado.AutoSize = true;
            this.Check_Estado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Check_Estado.Location = new System.Drawing.Point(332, 91);
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
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 348;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 347;
            this.label1.Text = "Producto:";
            // 
            // dgv_registros
            // 
            this.dgv_registros.AllowUserToAddRows = false;
            this.dgv_registros.AllowUserToDeleteRows = false;
            this.dgv_registros.AllowUserToResizeColumns = false;
            this.dgv_registros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_registros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_registros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_registros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_registros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_registros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(6, 169);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.RowHeadersWidth = 51;
            this.dgv_registros.Size = new System.Drawing.Size(1301, 383);
            this.dgv_registros.TabIndex = 347;
            this.dgv_registros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellDoubleClick);
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.ForeColor = System.Drawing.Color.Transparent;
            this.lblidproducto.Location = new System.Drawing.Point(12, 355);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(10, 13);
            this.lblidproducto.TabIndex = 3;
            this.lblidproducto.Text = "-";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNNUEVO,
            this.sprlibros,
            this.BTNGUARDAR,
            this.sprmiembros,
            this.BTNEDITAR,
            this.sprprestamos,
            this.Btn_Eliminar,
            this.sprreportes,
            this.BTNCANCELAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1307, 34);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.AutoSize = false;
            this.BTNNUEVO.BackColor = System.Drawing.Color.GhostWhite;
            this.BTNNUEVO.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTNNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(95, 31);
            this.BTNNUEVO.Text = "NUEVO F3";
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // sprlibros
            // 
            this.sprlibros.Name = "sprlibros";
            this.sprlibros.Size = new System.Drawing.Size(6, 34);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.GhostWhite;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Image")));
            this.BTNGUARDAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTNGUARDAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(110, 31);
            this.BTNGUARDAR.Text = "GUARDAR F4";
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // sprmiembros
            // 
            this.sprmiembros.Name = "sprmiembros";
            this.sprmiembros.Size = new System.Drawing.Size(6, 34);
            // 
            // BTNEDITAR
            // 
            this.BTNEDITAR.BackColor = System.Drawing.Color.GhostWhite;
            this.BTNEDITAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEDITAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNEDITAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNEDITAR.Image")));
            this.BTNEDITAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTNEDITAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(92, 31);
            this.BTNEDITAR.Text = "EDITAR F5";
            this.BTNEDITAR.Click += new System.EventHandler(this.BTNEDITAR_Click);
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
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.BackColor = System.Drawing.Color.GhostWhite;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCELAR.Image")));
            this.BTNCANCELAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTNCANCELAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(115, 31);
            this.BTNCANCELAR.Text = "CANCELAR F7";
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 632);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stprincipal);
            this.Controls.Add(this.panelBarraTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Productos_KeyDown);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.stprincipal.ResumeLayout(false);
            this.stprincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.StatusStrip stprincipal;
        private System.Windows.Forms.ToolStripStatusLabel lbluserlogin;
        private System.Windows.Forms.ToolStripStatusLabel lblfecha;
        private System.Windows.Forms.ToolStripStatusLabel lblusermanager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNNUEVO;
        private System.Windows.Forms.ToolStripSeparator sprlibros;
        private System.Windows.Forms.ToolStripButton BTNGUARDAR;
        private System.Windows.Forms.ToolStripSeparator sprmiembros;
        private System.Windows.Forms.ToolStripButton BTNEDITAR;
        private System.Windows.Forms.ToolStripSeparator sprprestamos;
        private System.Windows.Forms.ToolStripButton Btn_Eliminar;
        private System.Windows.Forms.ToolStripSeparator sprreportes;
        private System.Windows.Forms.ToolStripButton BTNCANCELAR;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_precio;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.CheckBox Check_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}