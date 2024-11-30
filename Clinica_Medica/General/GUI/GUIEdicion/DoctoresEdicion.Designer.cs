namespace General.GUI
{
    partial class DoctoresEdicion
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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumeroLicencia = new System.Windows.Forms.TextBox();
            this.txtID_Empleado = new System.Windows.Forms.TextBox();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID_Doctor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(115, 372);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(320, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 42);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // notificador
            // 
            this.notificador.ContainerControl = this;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(84, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 25);
            this.label20.TabIndex = 35;
            this.label20.Text = "Id Empleado";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(84, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 25);
            this.label19.TabIndex = 36;
            this.label19.Text = "Num. Licencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(83, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 37;
            this.label15.Text = "Especialidad";
            // 
            // txtNumeroLicencia
            // 
            this.txtNumeroLicencia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumeroLicencia.Location = new System.Drawing.Point(226, 196);
            this.txtNumeroLicencia.Name = "txtNumeroLicencia";
            this.txtNumeroLicencia.Size = new System.Drawing.Size(251, 34);
            this.txtNumeroLicencia.TabIndex = 39;
            // 
            // txtID_Empleado
            // 
            this.txtID_Empleado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID_Empleado.Location = new System.Drawing.Point(225, 134);
            this.txtID_Empleado.Name = "txtID_Empleado";
            this.txtID_Empleado.Size = new System.Drawing.Size(252, 34);
            this.txtID_Empleado.TabIndex = 38;
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Items.AddRange(new object[] {
            "Seleccione una Opcion"});
            this.cbxEspecialidad.Location = new System.Drawing.Point(226, 266);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(257, 36);
            this.cbxEspecialidad.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "ID Doctor: ";
            // 
            // txtID_Doctor
            // 
            this.txtID_Doctor.BackColor = System.Drawing.Color.White;
            this.txtID_Doctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID_Doctor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID_Doctor.Location = new System.Drawing.Point(226, 70);
            this.txtID_Doctor.Name = "txtID_Doctor";
            this.txtID_Doctor.ReadOnly = true;
            this.txtID_Doctor.Size = new System.Drawing.Size(78, 27);
            this.txtID_Doctor.TabIndex = 52;
            // 
            // DoctoresEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(580, 588);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtID_Doctor);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNumeroLicencia);
            this.Controls.Add(this.txtID_Empleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctoresEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctoresEdicion";
            this.Load += new System.EventHandler(this.DoctoresEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider notificador;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtNumeroLicencia;
        public System.Windows.Forms.TextBox txtID_Empleado;
        public System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtID_Doctor;
    }
}