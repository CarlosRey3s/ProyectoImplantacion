namespace General.GUI
{
    partial class EmpleadosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.VistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.dtbEmpleado = new System.Windows.Forms.DataGridView();
            this.ID_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ISSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargos_ID_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalEmpleados = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbEmpleado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtFiltro,
            this.toolStripLabel1,
            this.VistaPrevia});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(39, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(904, 48);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
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
            this.Eliminar.BackColor = System.Drawing.Color.White;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 45);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltro.BackColor = System.Drawing.Color.Snow;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltro.Size = new System.Drawing.Size(250, 48);
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 45);
            // 
            // VistaPrevia
            // 
            this.VistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("VistaPrevia.Image")));
            this.VistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VistaPrevia.Name = "VistaPrevia";
            this.VistaPrevia.Size = new System.Drawing.Size(105, 45);
            this.VistaPrevia.Text = "VistaPrevia";
            this.VistaPrevia.Click += new System.EventHandler(this.VistaPrevia_Click);
            // 
            // dtbEmpleado
            // 
            this.dtbEmpleado.AllowUserToAddRows = false;
            this.dtbEmpleado.AllowUserToDeleteRows = false;
            this.dtbEmpleado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = null;
            this.dtbEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtbEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtbEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dtbEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtbEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtbEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtbEmpleado.ColumnHeadersHeight = 30;
            this.dtbEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtbEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_empleado,
            this.Emp_Nombre,
            this.Emp_Apellido,
            this.Emp_FechaNacimiento,
            this.Emp_Telefono,
            this.Emp_DUI,
            this.Emp_ISSS,
            this.Emp_Correo,
            this.Emp_Direccion,
            this.Cargos_ID_Cargo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtbEmpleado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtbEmpleado.EnableHeadersVisualStyles = false;
            this.dtbEmpleado.GridColor = System.Drawing.SystemColors.Control;
            this.dtbEmpleado.Location = new System.Drawing.Point(39, 52);
            this.dtbEmpleado.MultiSelect = false;
            this.dtbEmpleado.Name = "dtbEmpleado";
            this.dtbEmpleado.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtbEmpleado.RowHeadersVisible = false;
            this.dtbEmpleado.RowHeadersWidth = 51;
            this.dtbEmpleado.RowTemplate.Height = 24;
            this.dtbEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbEmpleado.Size = new System.Drawing.Size(904, 441);
            this.dtbEmpleado.TabIndex = 6;
            // 
            // ID_empleado
            // 
            this.ID_empleado.DataPropertyName = "ID_Empleado";
            dataGridViewCellStyle3.Format = "N0";
            this.ID_empleado.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_empleado.HeaderText = "ID";
            this.ID_empleado.MinimumWidth = 6;
            this.ID_empleado.Name = "ID_empleado";
            this.ID_empleado.ReadOnly = true;
            this.ID_empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Emp_Nombre
            // 
            this.Emp_Nombre.DataPropertyName = "Emp_Nombre";
            this.Emp_Nombre.HeaderText = "Nombre";
            this.Emp_Nombre.MinimumWidth = 6;
            this.Emp_Nombre.Name = "Emp_Nombre";
            this.Emp_Nombre.ReadOnly = true;
            // 
            // Emp_Apellido
            // 
            this.Emp_Apellido.DataPropertyName = "Emp_Apellido";
            this.Emp_Apellido.HeaderText = "Apellido";
            this.Emp_Apellido.MinimumWidth = 6;
            this.Emp_Apellido.Name = "Emp_Apellido";
            this.Emp_Apellido.ReadOnly = true;
            // 
            // Emp_FechaNacimiento
            // 
            this.Emp_FechaNacimiento.DataPropertyName = "Emp_FechaNacimiento";
            this.Emp_FechaNacimiento.HeaderText = "FechaNacimiento";
            this.Emp_FechaNacimiento.MinimumWidth = 6;
            this.Emp_FechaNacimiento.Name = "Emp_FechaNacimiento";
            this.Emp_FechaNacimiento.ReadOnly = true;
            // 
            // Emp_Telefono
            // 
            this.Emp_Telefono.DataPropertyName = "Emp_Telefono";
            this.Emp_Telefono.HeaderText = "Telefono";
            this.Emp_Telefono.MinimumWidth = 6;
            this.Emp_Telefono.Name = "Emp_Telefono";
            this.Emp_Telefono.ReadOnly = true;
            // 
            // Emp_DUI
            // 
            this.Emp_DUI.DataPropertyName = "Emp_DUI";
            this.Emp_DUI.HeaderText = "DUI";
            this.Emp_DUI.MinimumWidth = 6;
            this.Emp_DUI.Name = "Emp_DUI";
            this.Emp_DUI.ReadOnly = true;
            // 
            // Emp_ISSS
            // 
            this.Emp_ISSS.DataPropertyName = "Emp_ISSS";
            this.Emp_ISSS.HeaderText = "ISSS";
            this.Emp_ISSS.MinimumWidth = 6;
            this.Emp_ISSS.Name = "Emp_ISSS";
            this.Emp_ISSS.ReadOnly = true;
            // 
            // Emp_Correo
            // 
            this.Emp_Correo.DataPropertyName = "Emp_Correo";
            this.Emp_Correo.HeaderText = "Correo";
            this.Emp_Correo.MinimumWidth = 6;
            this.Emp_Correo.Name = "Emp_Correo";
            this.Emp_Correo.ReadOnly = true;
            // 
            // Emp_Direccion
            // 
            this.Emp_Direccion.DataPropertyName = "Emp_Direccion";
            this.Emp_Direccion.HeaderText = "Direccion";
            this.Emp_Direccion.MinimumWidth = 6;
            this.Emp_Direccion.Name = "Emp_Direccion";
            this.Emp_Direccion.ReadOnly = true;
            this.Emp_Direccion.Visible = false;
            // 
            // Cargos_ID_Cargo
            // 
            this.Cargos_ID_Cargo.DataPropertyName = "Cargos_ID_Cargo";
            this.Cargos_ID_Cargo.HeaderText = "cargo";
            this.Cargos_ID_Cargo.MinimumWidth = 6;
            this.Cargos_ID_Cargo.Name = "Cargos_ID_Cargo";
            this.Cargos_ID_Cargo.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TotalEmpleados});
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(986, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "Número de Doctores:";
            // 
            // TotalEmpleados
            // 
            this.TotalEmpleados.Name = "TotalEmpleados";
            this.TotalEmpleados.Size = new System.Drawing.Size(17, 20);
            this.TotalEmpleados.Text = "0";
            this.TotalEmpleados.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // EmpleadosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 629);
            this.Controls.Add(this.dtbEmpleado);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmpleadosGestion";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmpleadosGestion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbEmpleado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dtbEmpleado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TotalEmpleados;
        private System.Windows.Forms.ToolStripButton VistaPrevia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ISSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargos_ID_Cargo;
    }
}