namespace General.GUI.GUIGestiones
{
    partial class FacturaGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalEmpleados = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fac_NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fac_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fac_MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacientes_ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consulta_ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Insertar,
            this.toolStripSeparator1,
            this.Modificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.txtFiltro,
            this.toolStripLabel2});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(31, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(678, 39);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(73, 36);
            this.Insertar.Text = "Agregar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(82, 36);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltro.Size = new System.Drawing.Size(187, 39);
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel2.Text = "Buscar";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AllowUserToResizeColumns = false;
            this.dgvFactura.AllowUserToResizeRows = false;
            this.dgvFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFactura.ColumnHeadersHeight = 30;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Factura,
            this.Fac_NumeroFactura,
            this.Fac_Fecha,
            this.Fac_MetodoPago,
            this.NombrePaciente,
            this.Pacientes_ID_Paciente,
            this.Consulta_ID_Consulta,
            this.PrecioConsulta,
            this.NombreDoctor});
            this.dgvFactura.EnableHeadersVisualStyles = false;
            this.dgvFactura.Location = new System.Drawing.Point(31, 50);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFactura.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactura.Size = new System.Drawing.Size(678, 370);
            this.dgvFactura.TabIndex = 7;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TotalEmpleados});
            this.statusStrip1.Location = new System.Drawing.Point(48, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(149, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "Número de Pacientes:";
            // 
            // TotalEmpleados
            // 
            this.TotalEmpleados.Name = "TotalEmpleados";
            this.TotalEmpleados.Size = new System.Drawing.Size(13, 17);
            this.TotalEmpleados.Text = "0";
            // 
            // ID_Factura
            // 
            this.ID_Factura.DataPropertyName = "ID_Factura";
            this.ID_Factura.FillWeight = 30F;
            this.ID_Factura.HeaderText = "ID";
            this.ID_Factura.MinimumWidth = 6;
            this.ID_Factura.Name = "ID_Factura";
            this.ID_Factura.ReadOnly = true;
            // 
            // Fac_NumeroFactura
            // 
            this.Fac_NumeroFactura.DataPropertyName = "Fac_NumeroFactura";
            this.Fac_NumeroFactura.HeaderText = "Número Factura";
            this.Fac_NumeroFactura.MinimumWidth = 6;
            this.Fac_NumeroFactura.Name = "Fac_NumeroFactura";
            this.Fac_NumeroFactura.ReadOnly = true;
            // 
            // Fac_Fecha
            // 
            this.Fac_Fecha.DataPropertyName = "Fac_Fecha";
            this.Fac_Fecha.HeaderText = "Fecha";
            this.Fac_Fecha.MinimumWidth = 6;
            this.Fac_Fecha.Name = "Fac_Fecha";
            this.Fac_Fecha.ReadOnly = true;
            // 
            // Fac_MetodoPago
            // 
            this.Fac_MetodoPago.DataPropertyName = "Fac_MetodoPago";
            this.Fac_MetodoPago.HeaderText = "Método Pago";
            this.Fac_MetodoPago.MinimumWidth = 6;
            this.Fac_MetodoPago.Name = "Fac_MetodoPago";
            this.Fac_MetodoPago.ReadOnly = true;
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.DataPropertyName = "NombrePaciente";
            this.NombrePaciente.HeaderText = "Paciente";
            this.NombrePaciente.Name = "NombrePaciente";
            this.NombrePaciente.ReadOnly = true;
            // 
            // Pacientes_ID_Paciente
            // 
            this.Pacientes_ID_Paciente.DataPropertyName = "Pacientes_ID_Paciente";
            this.Pacientes_ID_Paciente.HeaderText = "Pacientes_ID_Paciente";
            this.Pacientes_ID_Paciente.Name = "Pacientes_ID_Paciente";
            this.Pacientes_ID_Paciente.ReadOnly = true;
            this.Pacientes_ID_Paciente.Visible = false;
            // 
            // Consulta_ID_Consulta
            // 
            this.Consulta_ID_Consulta.DataPropertyName = "Consulta_ID_Consulta";
            this.Consulta_ID_Consulta.HeaderText = "Consulta";
            this.Consulta_ID_Consulta.Name = "Consulta_ID_Consulta";
            this.Consulta_ID_Consulta.ReadOnly = true;
            this.Consulta_ID_Consulta.Visible = false;
            // 
            // PrecioConsulta
            // 
            this.PrecioConsulta.DataPropertyName = "PrecioConsulta";
            this.PrecioConsulta.HeaderText = "PrecioConsulta";
            this.PrecioConsulta.Name = "PrecioConsulta";
            this.PrecioConsulta.ReadOnly = true;
            this.PrecioConsulta.Visible = false;
            // 
            // NombreDoctor
            // 
            this.NombreDoctor.DataPropertyName = "NombreDoctor";
            this.NombreDoctor.HeaderText = "NombreDoctor";
            this.NombreDoctor.Name = "NombreDoctor";
            this.NombreDoctor.ReadOnly = true;
            this.NombreDoctor.Visible = false;
            // 
            // FacturaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FacturaGestion";
            this.Text = "FacturaGestion";
            this.Load += new System.EventHandler(this.FacturaGestion_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TotalEmpleados;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fac_NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fac_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fac_MetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacientes_ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta_ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDoctor;
    }
}