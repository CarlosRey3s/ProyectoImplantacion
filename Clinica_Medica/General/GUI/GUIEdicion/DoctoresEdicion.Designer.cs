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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtID_Doctor = new System.Windows.Forms.TextBox();
            this.txtID_Empleado = new System.Windows.Forms.TextBox();
            this.txtNumeroLicencia = new System.Windows.Forms.TextBox();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDocEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Licencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label4.Location = new System.Drawing.Point(46, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especialidad";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(51, 268);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 34);
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
            this.btnCancelar.Location = new System.Drawing.Point(173, 268);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtID_Doctor
            // 
            this.txtID_Doctor.Location = new System.Drawing.Point(173, 49);
            this.txtID_Doctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID_Doctor.Name = "txtID_Doctor";
            this.txtID_Doctor.Size = new System.Drawing.Size(76, 20);
            this.txtID_Doctor.TabIndex = 6;
            // 
            // txtID_Empleado
            // 
            this.txtID_Empleado.Location = new System.Drawing.Point(173, 86);
            this.txtID_Empleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID_Empleado.Name = "txtID_Empleado";
            this.txtID_Empleado.Size = new System.Drawing.Size(76, 20);
            this.txtID_Empleado.TabIndex = 7;
            // 
            // txtNumeroLicencia
            // 
            this.txtNumeroLicencia.Location = new System.Drawing.Point(173, 126);
            this.txtNumeroLicencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroLicencia.Name = "txtNumeroLicencia";
            this.txtNumeroLicencia.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroLicencia.TabIndex = 8;
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(173, 168);
            this.cbxEspecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(92, 21);
            this.cbxEspecialidad.TabIndex = 9;
            // 
            // notificador
            // 
            this.notificador.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label5.Location = new System.Drawing.Point(46, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // cbxDocEstado
            // 
            this.cbxDocEstado.FormattingEnabled = true;
            this.cbxDocEstado.Location = new System.Drawing.Point(173, 212);
            this.cbxDocEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDocEstado.Name = "cbxDocEstado";
            this.cbxDocEstado.Size = new System.Drawing.Size(92, 21);
            this.cbxDocEstado.TabIndex = 11;
            // 
            // DoctoresEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 324);
            this.Controls.Add(this.cbxDocEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.txtNumeroLicencia);
            this.Controls.Add(this.txtID_Empleado);
            this.Controls.Add(this.txtID_Doctor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoctoresEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctoresEdicion";
            this.Load += new System.EventHandler(this.DoctoresEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider notificador;
        public System.Windows.Forms.TextBox txtID_Doctor;
        public System.Windows.Forms.TextBox txtID_Empleado;
        public System.Windows.Forms.TextBox txtNumeroLicencia;
        public System.Windows.Forms.ComboBox cbxEspecialidad;
        public System.Windows.Forms.ComboBox cbxDocEstado;
        private System.Windows.Forms.Label label5;
    }
}