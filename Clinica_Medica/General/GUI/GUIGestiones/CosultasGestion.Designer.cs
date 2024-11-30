namespace General.GUI.GUIGestiones
{
    partial class CosultasGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CosultasGestion));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultas.ColumnHeadersHeight = 29;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Consulta,
            this.ID_Receta,
            this.ID_Cita,
            this.NombresPaciente,
            this.ApellidosPaciente,
            this.ID_Doctor,
            this.NombresEmpleado,
            this.ID_Consultorio,
            this.NumeroLicencia,
            this.Diagnostico,
            this.Indicaciones});
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.Location = new System.Drawing.Point(37, 139);
            this.dgvConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(1067, 418);
            this.dgvConsultas.TabIndex = 16;
            // 
            // ID_Consulta
            // 
            this.ID_Consulta.DataPropertyName = "ID_Consulta";
            this.ID_Consulta.FillWeight = 50F;
            this.ID_Consulta.HeaderText = "ID";
            this.ID_Consulta.MinimumWidth = 6;
            this.ID_Consulta.Name = "ID_Consulta";
            this.ID_Consulta.ReadOnly = true;
            // 
            // ID_Receta
            // 
            this.ID_Receta.DataPropertyName = "ID_Receta";
            this.ID_Receta.HeaderText = "ID_Receta";
            this.ID_Receta.MinimumWidth = 6;
            this.ID_Receta.Name = "ID_Receta";
            this.ID_Receta.ReadOnly = true;
            this.ID_Receta.Visible = false;
            // 
            // ID_Cita
            // 
            this.ID_Cita.DataPropertyName = "ID_Cita";
            this.ID_Cita.HeaderText = "ID_Cita";
            this.ID_Cita.MinimumWidth = 6;
            this.ID_Cita.Name = "ID_Cita";
            this.ID_Cita.ReadOnly = true;
            this.ID_Cita.Visible = false;
            // 
            // NombresPaciente
            // 
            this.NombresPaciente.DataPropertyName = "NombresPaciente";
            this.NombresPaciente.HeaderText = "NombrePaciente";
            this.NombresPaciente.MinimumWidth = 6;
            this.NombresPaciente.Name = "NombresPaciente";
            this.NombresPaciente.ReadOnly = true;
            // 
            // ApellidosPaciente
            // 
            this.ApellidosPaciente.DataPropertyName = "ApellidosPaciente";
            this.ApellidosPaciente.HeaderText = "Apellidos Paciente";
            this.ApellidosPaciente.MinimumWidth = 6;
            this.ApellidosPaciente.Name = "ApellidosPaciente";
            this.ApellidosPaciente.ReadOnly = true;
            // 
            // ID_Doctor
            // 
            this.ID_Doctor.DataPropertyName = "ID_Doctor";
            this.ID_Doctor.HeaderText = "ID_Doctor";
            this.ID_Doctor.MinimumWidth = 6;
            this.ID_Doctor.Name = "ID_Doctor";
            this.ID_Doctor.ReadOnly = true;
            this.ID_Doctor.Visible = false;
            // 
            // NombresEmpleado
            // 
            this.NombresEmpleado.DataPropertyName = "NombresEmpleado";
            this.NombresEmpleado.HeaderText = "Nombre del Doctor";
            this.NombresEmpleado.MinimumWidth = 6;
            this.NombresEmpleado.Name = "NombresEmpleado";
            this.NombresEmpleado.ReadOnly = true;
            // 
            // ID_Consultorio
            // 
            this.ID_Consultorio.DataPropertyName = "ID_Consultorio";
            this.ID_Consultorio.HeaderText = "ID_Consultorio";
            this.ID_Consultorio.MinimumWidth = 6;
            this.ID_Consultorio.Name = "ID_Consultorio";
            this.ID_Consultorio.ReadOnly = true;
            this.ID_Consultorio.Visible = false;
            // 
            // NumeroLicencia
            // 
            this.NumeroLicencia.DataPropertyName = "NumeroLicencia";
            this.NumeroLicencia.HeaderText = "N* Lincencia";
            this.NumeroLicencia.MinimumWidth = 6;
            this.NumeroLicencia.Name = "NumeroLicencia";
            this.NumeroLicencia.ReadOnly = true;
            // 
            // Diagnostico
            // 
            this.Diagnostico.DataPropertyName = "Diagnostico";
            this.Diagnostico.HeaderText = "Dianostico";
            this.Diagnostico.MinimumWidth = 6;
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            // 
            // Indicaciones
            // 
            this.Indicaciones.DataPropertyName = "Indicaciones";
            this.Indicaciones.HeaderText = "Indicaciones";
            this.Indicaciones.MinimumWidth = 6;
            this.Indicaciones.Name = "Indicaciones";
            this.Indicaciones.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.Insertar,
            this.Modificar,
            this.toolStripSeparator2,
            this.Eliminar,
            this.txtFiltrar,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(37, 89);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1067, 48);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(82, 45);
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(97, 45);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 45);
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
            this.txtFiltrar.Size = new System.Drawing.Size(249, 48);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 45);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 87);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Consultas";
            // 
            // CosultasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 561);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CosultasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosultasGestion";
            this.Load += new System.EventHandler(this.CosultasGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLicencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicaciones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}