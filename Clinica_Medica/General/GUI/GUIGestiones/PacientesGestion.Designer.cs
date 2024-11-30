namespace General.GUI.GUIGestiones
{
    partial class PacientesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
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
            this.Eliminar,
            this.txtFiltro,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(31, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(714, 39);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(73, 36);
            this.Insertar.Text = "Agregar";
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
            this.Eliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(74, 36);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
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
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 36);
            this.toolStripButton1.Text = "Citas";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(83, 36);
            this.toolStripButton2.Text = "Consultas";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeight = 30;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Paciente,
            this.Pac_Nombre,
            this.Pac_Apellido,
            this.Pac_FechaNacimiento,
            this.Pac_Genero,
            this.Pac_Telefono,
            this.Pac_CorreoElectronico,
            this.Pac_Direccion});
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 46);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(751, 464);
            this.dgvPacientes.TabIndex = 14;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick_1);
            // 
            // ID_Paciente
            // 
            this.ID_Paciente.DataPropertyName = "ID_Paciente";
            this.ID_Paciente.FillWeight = 60.9137F;
            this.ID_Paciente.HeaderText = "ID_Paciente";
            this.ID_Paciente.MinimumWidth = 6;
            this.ID_Paciente.Name = "ID_Paciente";
            this.ID_Paciente.ReadOnly = true;
            this.ID_Paciente.Width = 106;
            // 
            // Pac_Nombre
            // 
            this.Pac_Nombre.DataPropertyName = "Pac_Nombre";
            this.Pac_Nombre.FillWeight = 115.9473F;
            this.Pac_Nombre.HeaderText = "NombresPaciente";
            this.Pac_Nombre.MinimumWidth = 6;
            this.Pac_Nombre.Name = "Pac_Nombre";
            this.Pac_Nombre.ReadOnly = true;
            this.Pac_Nombre.Width = 143;
            // 
            // Pac_Apellido
            // 
            this.Pac_Apellido.DataPropertyName = "Pac_Apellido";
            this.Pac_Apellido.FillWeight = 115.9473F;
            this.Pac_Apellido.HeaderText = "ApellidosPacientes";
            this.Pac_Apellido.MinimumWidth = 6;
            this.Pac_Apellido.Name = "Pac_Apellido";
            this.Pac_Apellido.ReadOnly = true;
            this.Pac_Apellido.Width = 150;
            // 
            // Pac_FechaNacimiento
            // 
            this.Pac_FechaNacimiento.DataPropertyName = "Pac_FechaNacimiento";
            this.Pac_FechaNacimiento.FillWeight = 115.9473F;
            this.Pac_FechaNacimiento.HeaderText = "FechaNacimiento";
            this.Pac_FechaNacimiento.MinimumWidth = 6;
            this.Pac_FechaNacimiento.Name = "Pac_FechaNacimiento";
            this.Pac_FechaNacimiento.ReadOnly = true;
            this.Pac_FechaNacimiento.Width = 142;
            // 
            // Pac_Genero
            // 
            this.Pac_Genero.DataPropertyName = "Pac_Genero";
            this.Pac_Genero.FillWeight = 43.40272F;
            this.Pac_Genero.HeaderText = "Genero";
            this.Pac_Genero.Name = "Pac_Genero";
            this.Pac_Genero.ReadOnly = true;
            this.Pac_Genero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pac_Genero.Width = 78;
            // 
            // Pac_Telefono
            // 
            this.Pac_Telefono.DataPropertyName = "Pac_Telefono";
            this.Pac_Telefono.FillWeight = 115.9473F;
            this.Pac_Telefono.HeaderText = "Telefono";
            this.Pac_Telefono.Name = "Pac_Telefono";
            this.Pac_Telefono.ReadOnly = true;
            this.Pac_Telefono.Width = 87;
            // 
            // Pac_CorreoElectronico
            // 
            this.Pac_CorreoElectronico.DataPropertyName = "Pac_CorreoElectronico";
            this.Pac_CorreoElectronico.FillWeight = 115.9473F;
            this.Pac_CorreoElectronico.HeaderText = "Correo";
            this.Pac_CorreoElectronico.Name = "Pac_CorreoElectronico";
            this.Pac_CorreoElectronico.ReadOnly = true;
            this.Pac_CorreoElectronico.Width = 75;
            // 
            // Pac_Direccion
            // 
            this.Pac_Direccion.DataPropertyName = "Pac_Direccion";
            this.Pac_Direccion.FillWeight = 115.9473F;
            this.Pac_Direccion.HeaderText = "Direccion";
            this.Pac_Direccion.Name = "Pac_Direccion";
            this.Pac_Direccion.ReadOnly = true;
            this.Pac_Direccion.Width = 93;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(775, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel1.Text = "Registros Encontrados:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(13, 17);
            this.lblRegistros.Text = "0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 36);
            // 
            // PacientesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(775, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PacientesGestion";
            this.Text = "PacientesGestion";
            this.Load += new System.EventHandler(this.PacientesGestion_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
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
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Direccion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        public System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}