namespace General.GUI.GUIEdicion
{
    partial class CitasEdicion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFecha_Hora = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtdCita = new System.Windows.Forms.TextBox();
            this.cbDoctores = new System.Windows.Forms.ComboBox();
            this.cbConsultorios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(45, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha y Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // dtpFecha_Hora
            // 
            this.dtpFecha_Hora.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFecha_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha_Hora.Location = new System.Drawing.Point(140, 62);
            this.dtpFecha_Hora.Name = "dtpFecha_Hora";
            this.dtpFecha_Hora.Size = new System.Drawing.Size(142, 20);
            this.dtpFecha_Hora.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Motivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Doctores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Consultorios";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(140, 143);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(142, 20);
            this.txtEstado.TabIndex = 30;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(140, 105);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(142, 20);
            this.txtMotivo.TabIndex = 29;
            // 
            // txtdCita
            // 
            this.txtdCita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdCita.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdCita.Location = new System.Drawing.Point(140, 27);
            this.txtdCita.Name = "txtdCita";
            this.txtdCita.ReadOnly = true;
            this.txtdCita.Size = new System.Drawing.Size(20, 22);
            this.txtdCita.TabIndex = 33;
            // 
            // cbDoctores
            // 
            this.cbDoctores.FormattingEnabled = true;
            this.cbDoctores.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbDoctores.Location = new System.Drawing.Point(140, 187);
            this.cbDoctores.Name = "cbDoctores";
            this.cbDoctores.Size = new System.Drawing.Size(142, 21);
            this.cbDoctores.TabIndex = 35;
            // 
            // cbConsultorios
            // 
            this.cbConsultorios.FormattingEnabled = true;
            this.cbConsultorios.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbConsultorios.Location = new System.Drawing.Point(140, 233);
            this.cbConsultorios.Name = "cbConsultorios";
            this.cbConsultorios.Size = new System.Drawing.Size(142, 21);
            this.cbConsultorios.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Pacientes";
            // 
            // cbPacientes
            // 
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbPacientes.Location = new System.Drawing.Point(140, 273);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(142, 21);
            this.cbPacientes.TabIndex = 38;
            // 
            // CitasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 424);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbConsultorios);
            this.Controls.Add(this.cbDoctores);
            this.Controls.Add(this.txtdCita);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha_Hora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CitasEdicion";
            this.Text = "CitasEdicion";
            this.Load += new System.EventHandler(this.CitasEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.DateTimePicker dtpFecha_Hora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtMotivo;
        public System.Windows.Forms.TextBox txtdCita;
        public System.Windows.Forms.ComboBox cbDoctores;
        public System.Windows.Forms.ComboBox cbConsultorios;
        public System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label label2;
    }
}