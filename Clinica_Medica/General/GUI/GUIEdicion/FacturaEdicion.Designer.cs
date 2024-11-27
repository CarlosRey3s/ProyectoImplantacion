namespace General.GUI.GUIEdicion
{
    partial class FacturaEdicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelecionarCliente = new System.Windows.Forms.Button();
            this.btnSeleccionarConsulta = new System.Windows.Forms.Button();
            this.txtID_Paciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.btnRecetaMedicamentos = new System.Windows.Forms.Button();
            this.dgvDetallesFactura = new System.Windows.Forms.DataGridView();
            this.ID_DetalleFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Det_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Det_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Det_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Det_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ccbDesc = new System.Windows.Forms.ComboBox();
            this.txtIDMedicamento = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPrecioConsulta = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDoc = new System.Windows.Forms.Label();
            this.lbPrecioUnitario = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 16);
            this.panel1.TabIndex = 53;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(149, 725);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 34);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(318, 725);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 34);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(77, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Fecha:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(151, 52);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(221, 29);
            this.txtNumeroFactura.TabIndex = 59;
            this.txtNumeroFactura.TextChanged += new System.EventHandler(this.txtNombresPaciente_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(149, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(223, 29);
            this.dtpFecha.TabIndex = 58;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFactura.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFactura.Location = new System.Drawing.Point(150, 29);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.ReadOnly = true;
            this.txtIdFactura.Size = new System.Drawing.Size(20, 22);
            this.txtIdFactura.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Número Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(103, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label4.Location = new System.Drawing.Point(25, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Metodo Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label5.Location = new System.Drawing.Point(69, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label6.Location = new System.Drawing.Point(58, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Consulta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SelecionarCliente
            // 
            this.SelecionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.SelecionarCliente.FlatAppearance.BorderSize = 0;
            this.SelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelecionarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.SelecionarCliente.ForeColor = System.Drawing.Color.White;
            this.SelecionarCliente.Location = new System.Drawing.Point(450, 161);
            this.SelecionarCliente.Name = "SelecionarCliente";
            this.SelecionarCliente.Size = new System.Drawing.Size(92, 29);
            this.SelecionarCliente.TabIndex = 66;
            this.SelecionarCliente.Text = "Selecionar";
            this.SelecionarCliente.UseVisualStyleBackColor = false;
            this.SelecionarCliente.Click += new System.EventHandler(this.SelecionarCliente_Click);
            // 
            // btnSeleccionarConsulta
            // 
            this.btnSeleccionarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSeleccionarConsulta.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarConsulta.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarConsulta.Location = new System.Drawing.Point(450, 201);
            this.btnSeleccionarConsulta.Name = "btnSeleccionarConsulta";
            this.btnSeleccionarConsulta.Size = new System.Drawing.Size(92, 29);
            this.btnSeleccionarConsulta.TabIndex = 69;
            this.btnSeleccionarConsulta.Text = "Selecionar";
            this.btnSeleccionarConsulta.UseVisualStyleBackColor = false;
            this.btnSeleccionarConsulta.Click += new System.EventHandler(this.btnSeleccionarConsulta_Click);
            // 
            // txtID_Paciente
            // 
            this.txtID_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_Paciente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID_Paciente.Location = new System.Drawing.Point(416, 162);
            this.txtID_Paciente.Name = "txtID_Paciente";
            this.txtID_Paciente.Size = new System.Drawing.Size(28, 29);
            this.txtID_Paciente.TabIndex = 70;
            this.txtID_Paciente.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label7.Location = new System.Drawing.Point(25, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Medicamentos:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMedicamento.Location = new System.Drawing.Point(149, 359);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(120, 29);
            this.txtMedicamento.TabIndex = 72;
            this.txtMedicamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRecetaMedicamentos
            // 
            this.btnRecetaMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRecetaMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnRecetaMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecetaMedicamentos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRecetaMedicamentos.ForeColor = System.Drawing.Color.White;
            this.btnRecetaMedicamentos.Location = new System.Drawing.Point(275, 358);
            this.btnRecetaMedicamentos.Name = "btnRecetaMedicamentos";
            this.btnRecetaMedicamentos.Size = new System.Drawing.Size(97, 29);
            this.btnRecetaMedicamentos.TabIndex = 73;
            this.btnRecetaMedicamentos.Text = "Selecionar";
            this.btnRecetaMedicamentos.UseVisualStyleBackColor = false;
            this.btnRecetaMedicamentos.Click += new System.EventHandler(this.btnRecetaMedicamentos_Click);
            // 
            // dgvDetallesFactura
            // 
            this.dgvDetallesFactura.AllowUserToAddRows = false;
            this.dgvDetallesFactura.AllowUserToDeleteRows = false;
            this.dgvDetallesFactura.AllowUserToResizeColumns = false;
            this.dgvDetallesFactura.AllowUserToResizeRows = false;
            this.dgvDetallesFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesFactura.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetallesFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetallesFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetallesFactura.ColumnHeadersHeight = 30;
            this.dgvDetallesFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DetalleFactura,
            this.Med_Nombre,
            this.ID_Medicamento,
            this.Med_PrecioUnitario,
            this.Det_Cantidad,
            this.Det_Descuento,
            this.Det_SubTotal,
            this.Det_Total,
            this.ID_Factura});
            this.dgvDetallesFactura.EnableHeadersVisualStyles = false;
            this.dgvDetallesFactura.Location = new System.Drawing.Point(22, 565);
            this.dgvDetallesFactura.Name = "dgvDetallesFactura";
            this.dgvDetallesFactura.ReadOnly = true;
            this.dgvDetallesFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetallesFactura.RowHeadersVisible = false;
            this.dgvDetallesFactura.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetallesFactura.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallesFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesFactura.Size = new System.Drawing.Size(520, 142);
            this.dgvDetallesFactura.TabIndex = 74;
            this.dgvDetallesFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesFactura_CellContentClick);
            // 
            // ID_DetalleFactura
            // 
            this.ID_DetalleFactura.DataPropertyName = "ID_DetalleFactura";
            this.ID_DetalleFactura.FillWeight = 32.77356F;
            this.ID_DetalleFactura.HeaderText = "ID";
            this.ID_DetalleFactura.Name = "ID_DetalleFactura";
            this.ID_DetalleFactura.ReadOnly = true;
            // 
            // Med_Nombre
            // 
            this.Med_Nombre.DataPropertyName = "Med_Nombre";
            this.Med_Nombre.FillWeight = 101.6004F;
            this.Med_Nombre.HeaderText = "Medicamento";
            this.Med_Nombre.Name = "Med_Nombre";
            this.Med_Nombre.ReadOnly = true;
            // 
            // ID_Medicamento
            // 
            this.ID_Medicamento.DataPropertyName = "ID_Medicamento";
            this.ID_Medicamento.HeaderText = "ID_Medicamento";
            this.ID_Medicamento.Name = "ID_Medicamento";
            this.ID_Medicamento.ReadOnly = true;
            this.ID_Medicamento.Visible = false;
            // 
            // Med_PrecioUnitario
            // 
            this.Med_PrecioUnitario.DataPropertyName = "Med_PrecioUnitario";
            this.Med_PrecioUnitario.HeaderText = "Med_PrecioUnitario";
            this.Med_PrecioUnitario.Name = "Med_PrecioUnitario";
            this.Med_PrecioUnitario.ReadOnly = true;
            this.Med_PrecioUnitario.Visible = false;
            // 
            // Det_Cantidad
            // 
            this.Det_Cantidad.DataPropertyName = "Det_Cantidad";
            this.Det_Cantidad.FillWeight = 60F;
            this.Det_Cantidad.HeaderText = "Cantidad";
            this.Det_Cantidad.Name = "Det_Cantidad";
            this.Det_Cantidad.ReadOnly = true;
            // 
            // Det_Descuento
            // 
            this.Det_Descuento.DataPropertyName = "Det_Descuento";
            this.Det_Descuento.HeaderText = "Det_Descuento";
            this.Det_Descuento.Name = "Det_Descuento";
            this.Det_Descuento.ReadOnly = true;
            this.Det_Descuento.Visible = false;
            // 
            // Det_SubTotal
            // 
            this.Det_SubTotal.DataPropertyName = "Det_SubTotal";
            this.Det_SubTotal.FillWeight = 80F;
            this.Det_SubTotal.HeaderText = "SubTotal";
            this.Det_SubTotal.Name = "Det_SubTotal";
            this.Det_SubTotal.ReadOnly = true;
            // 
            // Det_Total
            // 
            this.Det_Total.DataPropertyName = "Det_Total";
            this.Det_Total.FillWeight = 80F;
            this.Det_Total.HeaderText = "Total";
            this.Det_Total.Name = "Det_Total";
            this.Det_Total.ReadOnly = true;
            // 
            // ID_Factura
            // 
            this.ID_Factura.DataPropertyName = "ID_Factura";
            this.ID_Factura.HeaderText = "ID_Factura";
            this.ID_Factura.Name = "ID_Factura";
            this.ID_Factura.ReadOnly = true;
            this.ID_Factura.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(149, 394);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 29);
            this.txtCantidad.TabIndex = 75;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label8.Location = new System.Drawing.Point(63, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label9.Location = new System.Drawing.Point(53, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Descuento:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(450, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 34);
            this.btnAgregar.TabIndex = 79;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(450, 460);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 34);
            this.btnEliminar.TabIndex = 80;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ccbDesc
            // 
            this.ccbDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbDesc.FormattingEnabled = true;
            this.ccbDesc.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20"});
            this.ccbDesc.Location = new System.Drawing.Point(149, 429);
            this.ccbDesc.Name = "ccbDesc";
            this.ccbDesc.Size = new System.Drawing.Size(120, 29);
            this.ccbDesc.TabIndex = 81;
            this.ccbDesc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIDMedicamento
            // 
            this.txtIDMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDMedicamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIDMedicamento.Location = new System.Drawing.Point(378, 358);
            this.txtIDMedicamento.Name = "txtIDMedicamento";
            this.txtIDMedicamento.Size = new System.Drawing.Size(28, 29);
            this.txtIDMedicamento.TabIndex = 87;
            this.txtIDMedicamento.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(201, 274);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 34);
            this.btnGenerar.TabIndex = 88;
            this.btnGenerar.Text = "Generar Factura";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbbMetodoPago
            // 
            this.cbbMetodoPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMetodoPago.FormattingEnabled = true;
            this.cbbMetodoPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARGETA DE CREDITO",
            "TARGETA DE DEBITO",
            "OTRO"});
            this.cbbMetodoPago.Location = new System.Drawing.Point(149, 127);
            this.cbbMetodoPago.Name = "cbbMetodoPago";
            this.cbbMetodoPago.Size = new System.Drawing.Size(223, 29);
            this.cbbMetodoPago.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label12.Location = new System.Drawing.Point(-1, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 90;
            this.label12.Text = "Costo del Consulta:";
            // 
            // lbPrecioConsulta
            // 
            this.lbPrecioConsulta.AutoSize = true;
            this.lbPrecioConsulta.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lbPrecioConsulta.Location = new System.Drawing.Point(147, 324);
            this.lbPrecioConsulta.Name = "lbPrecioConsulta";
            this.lbPrecioConsulta.Size = new System.Drawing.Size(44, 20);
            this.lbPrecioConsulta.TabIndex = 91;
            this.lbPrecioConsulta.Text = "$0.00";
            this.lbPrecioConsulta.Click += new System.EventHandler(this.lbPrecioConsulta_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label14.Location = new System.Drawing.Point(69, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 93;
            this.label14.Text = "Doctor:";
            // 
            // lbDoc
            // 
            this.lbDoc.AutoSize = true;
            this.lbDoc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lbDoc.Location = new System.Drawing.Point(145, 240);
            this.lbDoc.Name = "lbDoc";
            this.lbDoc.Size = new System.Drawing.Size(137, 20);
            this.lbDoc.TabIndex = 94;
            this.lbDoc.Text = "Nombre del doctor";
            // 
            // lbPrecioUnitario
            // 
            this.lbPrecioUnitario.AutoSize = true;
            this.lbPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioUnitario.Location = new System.Drawing.Point(149, 466);
            this.lbPrecioUnitario.Name = "lbPrecioUnitario";
            this.lbPrecioUnitario.Size = new System.Drawing.Size(49, 21);
            this.lbPrecioUnitario.TabIndex = 96;
            this.lbPrecioUnitario.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 21);
            this.label11.TabIndex = 97;
            this.label11.Text = "Precio unitario:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label17.Location = new System.Drawing.Point(67, 499);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 98;
            this.label17.Text = "Subtotal:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.Location = new System.Drawing.Point(149, 499);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(49, 21);
            this.lbSubtotal.TabIndex = 99;
            this.lbSubtotal.Text = "$0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label16.Location = new System.Drawing.Point(90, 532);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 100;
            this.label16.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(149, 530);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 21);
            this.lbTotal.TabIndex = 101;
            this.lbTotal.Text = "$0.00";
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.Location = new System.Drawing.Point(149, 169);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNombreCliente.Size = new System.Drawing.Size(145, 21);
            this.lbNombreCliente.TabIndex = 103;
            this.lbNombreCliente.Text = "Nombre del Cliente";
            // 
            // txtConsulta
            // 
            this.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsulta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConsulta.Location = new System.Drawing.Point(153, 201);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.ReadOnly = true;
            this.txtConsulta.Size = new System.Drawing.Size(141, 29);
            this.txtConsulta.TabIndex = 68;
            // 
            // FacturaEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 771);
            this.Controls.Add(this.lbNombreCliente);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbPrecioUnitario);
            this.Controls.Add(this.lbDoc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbPrecioConsulta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbMetodoPago);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtIDMedicamento);
            this.Controls.Add(this.ccbDesc);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvDetallesFactura);
            this.Controls.Add(this.btnRecetaMedicamentos);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID_Paciente);
            this.Controls.Add(this.btnSeleccionarConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.SelecionarCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaEdicion";
            this.Load += new System.EventHandler(this.FacturaEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNumeroFactura;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSeleccionarConsulta;
        private System.Windows.Forms.Button SelecionarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtID_Paciente;
        public System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRecetaMedicamentos;
        public System.Windows.Forms.DataGridView dgvDetallesFactura;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox ccbDesc;
        public System.Windows.Forms.TextBox txtIDMedicamento;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cbbMetodoPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label lbNombreCliente;
        public System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Factura;
        public System.Windows.Forms.Label lbDoc;
        public System.Windows.Forms.Label lbPrecioUnitario;
        public System.Windows.Forms.Label lbPrecioConsulta;
    }
}