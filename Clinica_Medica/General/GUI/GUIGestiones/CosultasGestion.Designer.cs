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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CosultasGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_Diganostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_PrecioConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_PoseeCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Citas_ID_Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_FechaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(28, 72);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Consultas";
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultas.ColumnHeadersHeight = 30;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Consulta,
            this.Cons_Diganostico,
            this.Cons_Tratamiento,
            this.Cons_PrecioConsulta,
            this.Cons_PoseeCita,
            this.Citas_ID_Cita,
            this.Cons_FechaConsulta});
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.Location = new System.Drawing.Point(28, 114);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(800, 420);
            this.dgvConsultas.TabIndex = 16;
            // 
            // ID_Consulta
            // 
            this.ID_Consulta.DataPropertyName = "ID_Consulta";
            this.ID_Consulta.FillWeight = 76.14214F;
            this.ID_Consulta.HeaderText = "ID_Consulta";
            this.ID_Consulta.MinimumWidth = 3;
            this.ID_Consulta.Name = "ID_Consulta";
            this.ID_Consulta.ReadOnly = true;
            // 
            // Cons_Diganostico
            // 
            this.Cons_Diganostico.DataPropertyName = "Cons_Diganostico";
            this.Cons_Diganostico.FillWeight = 104.7716F;
            this.Cons_Diganostico.HeaderText = "Diagnostico";
            this.Cons_Diganostico.Name = "Cons_Diganostico";
            this.Cons_Diganostico.ReadOnly = true;
            // 
            // Cons_Tratamiento
            // 
            this.Cons_Tratamiento.DataPropertyName = "Cons_Tratamiento";
            this.Cons_Tratamiento.FillWeight = 104.7716F;
            this.Cons_Tratamiento.HeaderText = "Tratamiento";
            this.Cons_Tratamiento.Name = "Cons_Tratamiento";
            this.Cons_Tratamiento.ReadOnly = true;
            // 
            // Cons_PrecioConsulta
            // 
            this.Cons_PrecioConsulta.DataPropertyName = "Cons_PrecioConsulta";
            this.Cons_PrecioConsulta.FillWeight = 104.7716F;
            this.Cons_PrecioConsulta.HeaderText = "Precio";
            this.Cons_PrecioConsulta.Name = "Cons_PrecioConsulta";
            this.Cons_PrecioConsulta.ReadOnly = true;
            // 
            // Cons_PoseeCita
            // 
            this.Cons_PoseeCita.DataPropertyName = "Cons_PoseeCita";
            this.Cons_PoseeCita.HeaderText = "¿PoseeCita?";
            this.Cons_PoseeCita.Name = "Cons_PoseeCita";
            this.Cons_PoseeCita.ReadOnly = true;
            // 
            // Citas_ID_Cita
            // 
            this.Citas_ID_Cita.DataPropertyName = "Citas_ID_Cita";
            this.Citas_ID_Cita.FillWeight = 104.7716F;
            this.Citas_ID_Cita.HeaderText = "CitasID";
            this.Citas_ID_Cita.Name = "Citas_ID_Cita";
            this.Citas_ID_Cita.ReadOnly = true;
            // 
            // Cons_FechaConsulta
            // 
            this.Cons_FechaConsulta.DataPropertyName = "Cons_FechaConsulta";
            this.Cons_FechaConsulta.FillWeight = 104.7716F;
            this.Cons_FechaConsulta.HeaderText = "FechayHora";
            this.Cons_FechaConsulta.Name = "Cons_FechaConsulta";
            this.Cons_FechaConsulta.ReadOnly = true;
            // 
            // CosultasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 456);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "CosultasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosultasGestion";
            this.Load += new System.EventHandler(this.CosultasGestion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        public System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_Diganostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_PrecioConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_PoseeCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citas_ID_Cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_FechaConsulta;
    }
}