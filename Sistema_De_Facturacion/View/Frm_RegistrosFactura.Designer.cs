
namespace Sistema_De_Facturacion.View
{
    partial class Frm_RegistrosFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrosFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.stprincipal = new System.Windows.Forms.StatusStrip();
            this.lbluserlogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusermanager = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblidfactura = new System.Windows.Forms.Label();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.BTNELIMINAR = new Sistema_De_Facturacion.Clases_System.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MSKFECHA = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_busquedaprimaria = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_CancelarBusqueda = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBarraTitulo.SuspendLayout();
            this.stprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelBarraTitulo.Controls.Add(this.label3);
            this.panelBarraTitulo.Controls.Add(this.btn_minimizar);
            this.panelBarraTitulo.Controls.Add(this.btn_close);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(793, 32);
            this.panelBarraTitulo.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(287, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Registros de Facturas";
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
            this.btn_minimizar.Location = new System.Drawing.Point(731, 3);
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
            this.btn_close.Location = new System.Drawing.Point(761, 3);
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
            this.stprincipal.Location = new System.Drawing.Point(0, 414);
            this.stprincipal.Name = "stprincipal";
            this.stprincipal.Size = new System.Drawing.Size(793, 26);
            this.stprincipal.TabIndex = 344;
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
            // lblidfactura
            // 
            this.lblidfactura.AutoSize = true;
            this.lblidfactura.ForeColor = System.Drawing.Color.Transparent;
            this.lblidfactura.Location = new System.Drawing.Point(12, 379);
            this.lblidfactura.Name = "lblidfactura";
            this.lblidfactura.Size = new System.Drawing.Size(10, 13);
            this.lblidfactura.TabIndex = 347;
            this.lblidfactura.Text = "-";
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
            this.dgv_registros.Location = new System.Drawing.Point(4, 156);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.Size = new System.Drawing.Size(789, 213);
            this.dgv_registros.TabIndex = 348;
            this.dgv_registros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellDoubleClick);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNELIMINAR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNELIMINAR.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BTNELIMINAR.BorderRadius = 20;
            this.BTNELIMINAR.BorderSize = 0;
            this.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNELIMINAR.FlatAppearance.BorderSize = 0;
            this.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.White;
            this.BTNELIMINAR.Location = new System.Drawing.Point(640, 370);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(145, 32);
            this.BTNELIMINAR.TabIndex = 346;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.TextColor = System.Drawing.Color.White;
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MSKFECHA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.msk_busquedaprimaria);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Btn_Imprimir);
            this.groupBox1.Controls.Add(this.Btn_CancelarBusqueda);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(4, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 79);
            this.groupBox1.TabIndex = 349;
            this.groupBox1.TabStop = false;
            // 
            // MSKFECHA
            // 
            this.MSKFECHA.Location = new System.Drawing.Point(462, 38);
            this.MSKFECHA.Mask = "00/00/0000";
            this.MSKFECHA.Name = "MSKFECHA";
            this.MSKFECHA.Size = new System.Drawing.Size(99, 20);
            this.MSKFECHA.TabIndex = 350;
            this.MSKFECHA.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(275, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 349;
            this.label1.Text = "BUSCAR POR FECHA:";
            // 
            // msk_busquedaprimaria
            // 
            this.msk_busquedaprimaria.Location = new System.Drawing.Point(158, 39);
            this.msk_busquedaprimaria.Name = "msk_busquedaprimaria";
            this.msk_busquedaprimaria.Size = new System.Drawing.Size(112, 20);
            this.msk_busquedaprimaria.TabIndex = 348;
            this.msk_busquedaprimaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_busquedaprimaria_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(10, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 347;
            this.label10.Text = "BUSCAR POR ID:";
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Location = new System.Drawing.Point(678, 37);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(41, 23);
            this.Btn_Imprimir.TabIndex = 346;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_CancelarBusqueda
            // 
            this.Btn_CancelarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CancelarBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarBusqueda.Image")));
            this.Btn_CancelarBusqueda.Location = new System.Drawing.Point(631, 37);
            this.Btn_CancelarBusqueda.Name = "Btn_CancelarBusqueda";
            this.Btn_CancelarBusqueda.Size = new System.Drawing.Size(41, 23);
            this.Btn_CancelarBusqueda.TabIndex = 344;
            this.Btn_CancelarBusqueda.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(584, 36);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(41, 23);
            this.Btn_Buscar.TabIndex = 345;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(14, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 24);
            this.label5.TabIndex = 363;
            this.label5.Text = "  REGISTRO DE FACTURACION";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_RegistrosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_registros);
            this.Controls.Add(this.lblidfactura);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.stprincipal);
            this.Controls.Add(this.panelBarraTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RegistrosFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_RegistrosFactura_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.stprincipal.ResumeLayout(false);
            this.stprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.StatusStrip stprincipal;
        private System.Windows.Forms.ToolStripStatusLabel lbluserlogin;
        private System.Windows.Forms.ToolStripStatusLabel lblfecha;
        private System.Windows.Forms.ToolStripStatusLabel lblusermanager;
        private Clases_System.RJButton BTNELIMINAR;
        private System.Windows.Forms.Label lblidfactura;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MSKFECHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_busquedaprimaria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_CancelarBusqueda;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label5;
    }
}