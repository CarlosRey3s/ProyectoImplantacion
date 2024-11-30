namespace General.GUI.GUIGestiones
{
    partial class CitasGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Registro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnFactura = new System.Windows.Forms.ToolStripButton();
            this.btnConsulta = new System.Windows.Forms.ToolStripButton();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.ID_Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cit_FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cit_Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cit_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacientes_ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctores_ID_Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultorios_ID_Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.Registro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(934, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(147, 20);
            this.toolStripStatusLabel2.Text = "Registros Encontrados:";
            // 
            // Registro
            // 
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(13, 20);
            this.Registro.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Insertar,
            this.toolStripSeparator1,
            this.Modificar,
            this.toolStripSeparator2,
            this.Eliminar,
            this.txtFiltrar,
            this.toolStripLabel1,
            this.btnFactura,
            this.btnConsulta});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(32, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(873, 39);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(70, 36);
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
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
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.White;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(74, 36);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltrar.Size = new System.Drawing.Size(187, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 36);
            // 
            // btnFactura
            // 
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(70, 36);
            this.btnFactura.Text = "Factura";
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(78, 36);
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.ColumnHeadersHeight = 30;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cita,
            this.Cit_FechaHora,
            this.Cit_Motivo,
            this.Cit_Estado,
            this.Pacientes_ID_Paciente,
            this.Doctores_ID_Doctor,
            this.Consultorios_ID_Consultorio});
            this.dgvCitas.EnableHeadersVisualStyles = false;
            this.dgvCitas.Location = new System.Drawing.Point(32, 47);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(873, 420);
            this.dgvCitas.TabIndex = 13;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            // 
            // ID_Cita
            // 
            this.ID_Cita.DataPropertyName = "ID_Cita";
            this.ID_Cita.HeaderText = "ID_Cita";
            this.ID_Cita.MinimumWidth = 6;
            this.ID_Cita.Name = "ID_Cita";
            this.ID_Cita.ReadOnly = true;
            // 
            // Cit_FechaHora
            // 
            this.Cit_FechaHora.DataPropertyName = "Cit_FechaHora";
            this.Cit_FechaHora.HeaderText = "Fecha y Hora";
            this.Cit_FechaHora.MinimumWidth = 6;
            this.Cit_FechaHora.Name = "Cit_FechaHora";
            this.Cit_FechaHora.ReadOnly = true;
            // 
            // Cit_Motivo
            // 
            this.Cit_Motivo.DataPropertyName = "Cit_Motivo";
            this.Cit_Motivo.HeaderText = "Motivo";
            this.Cit_Motivo.Name = "Cit_Motivo";
            this.Cit_Motivo.ReadOnly = true;
            // 
            // Cit_Estado
            // 
            this.Cit_Estado.DataPropertyName = "Cit_Estado";
            this.Cit_Estado.HeaderText = "Estado";
            this.Cit_Estado.Name = "Cit_Estado";
            this.Cit_Estado.ReadOnly = true;
            // 
            // Pacientes_ID_Paciente
            // 
            this.Pacientes_ID_Paciente.DataPropertyName = "Pacientes_ID_Paciente";
            this.Pacientes_ID_Paciente.HeaderText = "Expediente";
            this.Pacientes_ID_Paciente.Name = "Pacientes_ID_Paciente";
            this.Pacientes_ID_Paciente.ReadOnly = true;
            // 
            // Doctores_ID_Doctor
            // 
            this.Doctores_ID_Doctor.DataPropertyName = "Doctores_ID_Doctor";
            this.Doctores_ID_Doctor.HeaderText = "Doctores";
            this.Doctores_ID_Doctor.Name = "Doctores_ID_Doctor";
            this.Doctores_ID_Doctor.ReadOnly = true;
            // 
            // Consultorios_ID_Consultorio
            // 
            this.Consultorios_ID_Consultorio.DataPropertyName = "Consultorios_ID_Consultorio";
            this.Consultorios_ID_Consultorio.HeaderText = "Consultorios";
            this.Consultorios_ID_Consultorio.Name = "Consultorios_ID_Consultorio";
            this.Consultorios_ID_Consultorio.ReadOnly = true;
            // 
            // CitasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CitasGestion";
            this.Text = "CitasGestion";
            this.Load += new System.EventHandler(this.CitasGestion_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ToolStripButton btnConsulta;
        private System.Windows.Forms.ToolStripButton btnFactura;
        public System.Windows.Forms.ToolStripStatusLabel Registro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cit_FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cit_Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cit_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacientes_ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctores_ID_Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultorios_ID_Consultorio;
    }
}