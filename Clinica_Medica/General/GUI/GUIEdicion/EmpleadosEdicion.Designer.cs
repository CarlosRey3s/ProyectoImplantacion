namespace General.GUI
{
    partial class EmpleadosEdicion
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
            this.dTFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.txtID_Direccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTFechaNac
            // 
            this.dTFechaNac.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dTFechaNac.Location = new System.Drawing.Point(237, 275);
            this.dTFechaNac.Name = "dTFechaNac";
            this.dTFechaNac.Size = new System.Drawing.Size(252, 34);
            this.dTFechaNac.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "ID Empleado: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(133, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Direccion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(154, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cargo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(172, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "DUI:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(135, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Telefono:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(148, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "Correo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(167, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 25);
            this.label17.TabIndex = 19;
            this.label17.Text = "ISSS:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(67, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 25);
            this.label18.TabIndex = 23;
            this.label18.Text = "FechaNacimiento:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(136, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 25);
            this.label19.TabIndex = 22;
            this.label19.Text = "Apellido:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(136, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Nombre:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIDEmpleado.Location = new System.Drawing.Point(237, 28);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.ReadOnly = true;
            this.txtIDEmpleado.Size = new System.Drawing.Size(78, 27);
            this.txtIDEmpleado.TabIndex = 30;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreEmpleado.Location = new System.Drawing.Point(233, 74);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(252, 34);
            this.txtNombreEmpleado.TabIndex = 31;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(233, 136);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(251, 34);
            this.txtApellidoEmpleado.TabIndex = 32;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(233, 207);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(251, 34);
            this.txtTelefono.TabIndex = 34;
            // 
            // txtISSS
            // 
            this.txtISSS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtISSS.Location = new System.Drawing.Point(233, 339);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(172, 34);
            this.txtISSS.TabIndex = 35;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCorreo.Location = new System.Drawing.Point(233, 525);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(257, 34);
            this.txtCorreo.TabIndex = 36;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(233, 588);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 34);
            this.txtDireccion.TabIndex = 38;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(138, 670);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 48);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(407, 670);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 48);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Cancelar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // notificador
            // 
            this.notificador.BlinkRate = 0;
            this.notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.notificador.ContainerControl = this;
            // 
            // txtDUI
            // 
            this.txtDUI.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDUI.Location = new System.Drawing.Point(233, 403);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(172, 34);
            this.txtDUI.TabIndex = 33;
            // 
            // cbxCargo
            // 
            this.cbxCargo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Seleccione una Opcion"});
            this.cbxCargo.Location = new System.Drawing.Point(233, 462);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(257, 36);
            this.cbxCargo.TabIndex = 49;
            this.cbxCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // txtID_Direccion
            // 
            this.txtID_Direccion.Location = new System.Drawing.Point(893, 481);
            this.txtID_Direccion.Name = "txtID_Direccion";
            this.txtID_Direccion.Size = new System.Drawing.Size(38, 22);
            this.txtID_Direccion.TabIndex = 51;
            this.txtID_Direccion.VisibleChanged += new System.EventHandler(this.EmpleadosEdicion_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbxCargo);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtISSS);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtDUI);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtApellidoEmpleado);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtIDEmpleado);
            this.panel1.Controls.Add(this.dTFechaNac);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 751);
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpleadosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID_Direccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EmpleadosEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider notificador;
        public System.Windows.Forms.DateTimePicker dTFechaNac;
        public System.Windows.Forms.TextBox txtIDEmpleado;
        public System.Windows.Forms.TextBox txtNombreEmpleado;
        public System.Windows.Forms.TextBox txtApellidoEmpleado;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtISSS;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtDUI;
        public System.Windows.Forms.ComboBox cbxCargo;
        public System.Windows.Forms.TextBox txtID_Direccion;
        private System.Windows.Forms.Panel panel1;
    }
}