namespace General.GUI
{
    partial class DoctoresGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctoresGestion));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtbDoctor = new System.Windows.Forms.DataGridView();
            this.ID_Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLIcencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDoctor)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(985, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "Número de Doctores:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // dtbDoctor
            // 
            this.dtbDoctor.AllowUserToAddRows = false;
            this.dtbDoctor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dtbDoctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtbDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbDoctor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtbDoctor.BackgroundColor = System.Drawing.Color.White;
            this.dtbDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtbDoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtbDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtbDoctor.ColumnHeadersHeight = 30;
            this.dtbDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Doctor,
            this.ID_Empleado,
            this.NombresEmpleado,
            this.ApellidosEmpleado,
            this.TelefonoEmpleado,
            this.NumeroLIcencia,
            this.Especialidad,
            this.Correo});
            this.dtbDoctor.EnableHeadersVisualStyles = false;
            this.dtbDoctor.Location = new System.Drawing.Point(41, 61);
            this.dtbDoctor.MultiSelect = false;
            this.dtbDoctor.Name = "dtbDoctor";
            this.dtbDoctor.ReadOnly = true;
            this.dtbDoctor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtbDoctor.RowHeadersVisible = false;
            this.dtbDoctor.RowHeadersWidth = 51;
            this.dtbDoctor.RowTemplate.Height = 24;
            this.dtbDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbDoctor.Size = new System.Drawing.Size(908, 408);
            this.dtbDoctor.TabIndex = 5;
            // 
            // ID_Doctor
            // 
            this.ID_Doctor.DataPropertyName = "ID_Doctor";
            this.ID_Doctor.HeaderText = "ID_Doctor";
            this.ID_Doctor.MinimumWidth = 6;
            this.ID_Doctor.Name = "ID_Doctor";
            this.ID_Doctor.ReadOnly = true;
            this.ID_Doctor.Width = 125;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.HeaderText = "ID_Empleado";
            this.ID_Empleado.MinimumWidth = 6;
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.ReadOnly = true;
            this.ID_Empleado.Width = 125;
            // 
            // NombresEmpleado
            // 
            this.NombresEmpleado.DataPropertyName = "NombresEmpleado";
            this.NombresEmpleado.HeaderText = "Nombre";
            this.NombresEmpleado.MinimumWidth = 6;
            this.NombresEmpleado.Name = "NombresEmpleado";
            this.NombresEmpleado.ReadOnly = true;
            this.NombresEmpleado.Width = 200;
            // 
            // ApellidosEmpleado
            // 
            this.ApellidosEmpleado.DataPropertyName = "ApellidosEmpleado";
            this.ApellidosEmpleado.HeaderText = "Apellido";
            this.ApellidosEmpleado.MinimumWidth = 6;
            this.ApellidosEmpleado.Name = "ApellidosEmpleado";
            this.ApellidosEmpleado.ReadOnly = true;
            this.ApellidosEmpleado.Width = 200;
            // 
            // TelefonoEmpleado
            // 
            this.TelefonoEmpleado.DataPropertyName = "TelefonoEmpleado";
            this.TelefonoEmpleado.HeaderText = "Telefono";
            this.TelefonoEmpleado.MinimumWidth = 6;
            this.TelefonoEmpleado.Name = "TelefonoEmpleado";
            this.TelefonoEmpleado.ReadOnly = true;
            this.TelefonoEmpleado.Width = 200;
            // 
            // NumeroLIcencia
            // 
            this.NumeroLIcencia.DataPropertyName = "NumeroLIcencia";
            this.NumeroLIcencia.HeaderText = "NumeroLIcencia";
            this.NumeroLIcencia.MinimumWidth = 6;
            this.NumeroLIcencia.Name = "NumeroLIcencia";
            this.NumeroLIcencia.ReadOnly = true;
            this.NumeroLIcencia.Width = 200;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 200;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
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
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.txtFiltro,
            this.toolStripLabel2});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(41, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(908, 58);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 55);
            this.toolStripButton1.Text = "Agregar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(97, 55);
            this.toolStripButton2.Text = "Modificar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(87, 55);
            this.toolStripButton3.Text = "Eliminar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltro.Size = new System.Drawing.Size(249, 58);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 55);
            this.toolStripLabel2.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoctoresGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 498);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtbDoctor);
            this.Controls.Add(this.statusStrip1);
            this.Name = "DoctoresGestion";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDoctor)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView dtbDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLIcencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button button1;
    }
}